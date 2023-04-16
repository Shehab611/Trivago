using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Database_control
    {
        static string ordb = @"Data source=localhost:1521/xe;User Id=scott;Password=tiger;";
        static OracleConnection conn=new OracleConnection(ordb);
       
        public bool CheckOnLogin(string email,string password) {
            conn.Open();
            try {
                 OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select email,pass,role_id from userss where email =:email";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("email", email);

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[1].ToString() == password)
                {
                    dr.Close();
                    cmd.Cancel();
                    conn.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    cmd.Cancel();
                    conn.Close();
                    return false;
                }


            }
            catch (Exception)
            {
               
               
                conn.Close();
                return false;
            }
          
        }

        public int GetRole(string email) {
             OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.Connection = conn;
            cmd.CommandText = "select role_id from userss where email =:email";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", email);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int x = int.Parse(dr[0].ToString());
            cmd.Cancel();
            conn.Close();
            return x;
        }
    }
}
