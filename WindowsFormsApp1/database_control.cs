﻿using ExCSS;
using Oracle.ManagedDataAccess.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    internal class Database_control
        
    {
    //mohand connection string
        static string ordb = @"Data source=localhost:1521/orcl;User Id=scott;Password=tiger;";
        //shehab connection string
        static string ordb1 = @"Data source=localhost:1521/xe;User Id=scott;Password=tiger;";
        //gemi connection string
        static string ordb2 = @"User Id=team132;Password=team132;Data Source=localhost:1521/orcl";

        private OracleConnection conn=new OracleConnection(ordb1);

        public bool CheckOnLogin(string email, string password)
        {
            // Select rows from DB using bind variables and command parameters
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select pass from userss where email =:email";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("email", email);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    if (dr[0].ToString() == password)
                    {
                        dr.Close();
                        cmd.Cancel();
                        conn.Close();
                        return true;
                    }
                }
                dr.Close();
                cmd.Cancel();
                conn.Close();
                return false;
                


            }
            catch (Exception)
            {


                conn.Close();
                return false;
            }

        }

        public int GetRole(string email)
        {
            //Select ONE row from DB using stored Procedures (Without using SysRefCursor) [use out
            //parameters of Number data type]
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
           
            cmd.CommandText = "get_user_role";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("user_email", email);
            cmd.Parameters.Add("user_role_id", OracleDbType.Int64,ParameterDirection.Output);
            cmd.ExecuteNonQuery();
           
            int x = int.Parse(cmd.Parameters["user_role_id"].Value.ToString());
            cmd.Cancel();
            conn.Close();
            return x;
        }
       
        public User_in_DataBase GetUserData(string email) {
            User_in_DataBase user = new User_in_DataBase();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from userss where email =:email";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("email", email);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                user.User_id = int.Parse(dr[0].ToString());
                user.Ssn = dr[1].ToString();
                user.Email = dr[2].ToString();
                user.Pass = dr[3].ToString();
                user.F_name = dr[4].ToString();
                user.L_name = dr[5].ToString();
                user.Role_id = int.Parse(dr[6].ToString());
                user.Phone = dr[7].ToString();
                conn.Close();

                return user;
            }
            catch (Exception)
            {


                conn.Close();
               
            }
            return user;
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
            //Insert rows (Without using Procedures)
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
         
            cmd.CommandText = "insert into userss values(users_id_seq.nextval,:ssn,:email,:pass,:f_name,:l_name,:role_id,:phone)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn", user_In_DataBase.Ssn);
            cmd.Parameters.Add("email", user_In_DataBase.Email);
            cmd.Parameters.Add("pass", user_In_DataBase.Pass);
            cmd.Parameters.Add("f_name", user_In_DataBase.F_name);
            cmd.Parameters.Add("l_name", user_In_DataBase.L_name);
            cmd.Parameters.Add("role_id", user_In_DataBase.Role_id);
            cmd.Parameters.Add("phone", user_In_DataBase.Phone);
            int r = cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn.Close();
        }

        public void AddUserActivity(int user_id) {
            //insert into user_activity values(users_activity_id_seq.nextval,'15/9/2022 12:00','cairo',1);

            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
           
            cmd.CommandText = "insert into user_activity values(users_activity_id_seq.nextval,:datee,'cairo',:user_id)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("datee", DateTime.Now.ToString());
            cmd.Parameters.Add("user_id", user_id);
            int r = cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn.Close();

        }
      
        OracleDataAdapter useradapter ;
        DataSet userdataSet = new DataSet();
        public DataTable GetAllUsers()
        {

            string cmdstr = "select * from userss";
            useradapter = new OracleDataAdapter(cmdstr, ordb1);
          
          
            useradapter.Fill(userdataSet);
            return userdataSet.Tables[0];
        }

        public void UpdateUserData()
        {
            //Update using oracle command builder
            OracleCommandBuilder builder = new OracleCommandBuilder(useradapter);
            useradapter.Update(userdataSet.Tables[0]);
        }
        public DataTable GetPendingOffers()
        {
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select describtion,price,hotel_id from offers where state='0'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataSet dataSet = new DataSet();
            DataTable offers = dataSet.Tables.Add("Pending Offers");
            offers.Columns.Add("Offer ID");
            offers.Columns.Add("Hotel Name");
            offers.Columns.Add("Offer Describtion");
            offers.Columns.Add("Offer Price");
            int i = 0;
            while (dr.Read())
            {
                i++;
                offers.Rows.Add(i, GetHotelName(int.Parse(dr[2].ToString())), dr[0].ToString(), dr[1].ToString());

            }

            cmd.Cancel();
            conn.Close();
            return dataSet.Tables["Pending Offers"];
        }
       
        public DataTable Show_review(int Hotel_id)
        {//Select multiple rows from DB using stored procedures.
            
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "get_Reviews";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pro_hotel_id", Hotel_id);
            cmd.Parameters.Add("describtion", OracleDbType.RefCursor, ParameterDirection.Output);
            DataSet dataSet = new DataSet();
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable customers = dataSet.Tables.Add("Reviews");
            customers.Columns.Add("Review_ID");
            customers.Columns.Add("Review");


            int i = 0;
            while (dr.Read())
            {
                i++;
                customers.Rows.Add(i, dr[0].ToString());

            }



            cmd.Cancel();
            conn.Close();
            return dataSet.Tables["Reviews"];
        }

        public void AddOffer(string describtion,int price,int userid)
        {
           
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into offers values(offers_id_seq.nextval,:descr,:price,:hotel_id,0)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("descr", describtion);
            cmd.Parameters.Add("price", price);
           cmd.Parameters.Add("hotel_id", GetHotelID(userid));
       
            int r = cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn.Close();
        }

        public string GetHotelID(int user_id) {
            
            OracleCommand cmd = new OracleCommand();
            
            cmd.Connection = conn;
            cmd.CommandText = "select hotel_id  from hotel where user_id =:user_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("user_id", user_id);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String x = dr[0].ToString();
            
            return x;
        }
        public string GetHotelName(int hotel_id)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name  from hotel where hotel_id =:hotel_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("hotel_id", hotel_id);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String x = dr[0].ToString();

            return x;
        }

    }
  









    public class User_in_DataBase
    {
        private int role_id,user_id;
        private string email, pass, f_name, l_name, phone, ssn;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string F_name
        {
            get { return f_name; }
            set { f_name = value; }
        }
        public string L_name
        {
            get { return l_name; }
            set { l_name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public int Role_id
        {
            get { return role_id; }
            set { role_id = value; }
        }

        public User_in_DataBase() { }
        
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
