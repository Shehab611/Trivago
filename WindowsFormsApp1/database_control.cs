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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    internal class Database_control
    {
        static string ordb = @"Data source=localhost:1521/xe;User Id=scott;Password=tiger;";
        static OracleConnection conn = new OracleConnection(ordb);

        public bool CheckOnLogin(string email, string password)
        {
            conn.Open();
            try
            {
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

        public int GetRole(string email)
        {
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

        public bool CheckIfEmailExist(string email)
        {

            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select email from userss where email =:email";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("email", email);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                String x = dr[0].ToString();
                conn.Close();
                return true;

            }
            catch (Exception)
            {


                conn.Close();
                return false;
            }


        }
        public bool CheckIfPhoneExist(string phoneNumber)
        {

            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select phone from userss";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[0].ToString() == phoneNumber)
                    {

                        return true;
                    }


                }
                conn.Close();
                return false;

            }
            catch (Exception)
            {


                conn.Close();
                return false;
            }


        }

        public void AddUser(User_in_DataBase user_In_DataBase)
        {
            
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.Connection = conn;
            cmd.CommandText = "insert into userss values(users_id_seq.nextval,:ssn,:email,:pass,:f_name,:l_name,:role_id,:phone)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", user_In_DataBase.ssn);
            cmd.Parameters.Add("email", user_In_DataBase.email);
            cmd.Parameters.Add("pass", user_In_DataBase.pass);
            cmd.Parameters.Add("f_name", user_In_DataBase.f_name);
            cmd.Parameters.Add("l_name", user_In_DataBase.l_name);
            cmd.Parameters.Add("role_id", user_In_DataBase.role_id);
            cmd.Parameters.Add("phone", user_In_DataBase.phone);
            int r = cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn.Close();
        }
    }
    internal class User_in_DataBase
    {
        public int role_id;
        public string email, pass, f_name, l_name, phone, ssn;

        public User_in_DataBase(string email, string pass, string f_name, string l_name, int role_id, string phone, string ssn)
        {

            this.email = email;
            this.pass = pass;
            this.f_name = f_name;
            this.l_name = l_name;
            this.role_id = role_id;
            this.phone = phone;
            this.ssn = ssn;

        }
    }

}
