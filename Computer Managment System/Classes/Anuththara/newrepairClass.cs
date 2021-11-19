using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Managment_System.Classes
{
    class newrepairClass
    {
        //Geter and Service Properties
        //Acts as Data Carries in our Application 
        public int JobID { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ContactNo { get; set; }
        public string TechnicalNote { get; set; }



        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //private SqlDataAdapter adapter;

        //Selcting Data from Database
        public DataTable Select()
        {
            //step01 : Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM tbl_newrepair";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Inserting Data into Database
        public bool Insert(newrepairClass c)
        {
            //Creating a default return type and set its value to flase
            bool isSuccess = false;
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2; Create a SQL Query to insert Date
                string sql = "INSERT INTO tbl_newrepair (ClientName, ClientAddress, ContactNo, TechnicalNote)VALUES(@ClientName, @ClientAddress, @ContactNo, @TechnicalNote)";
                ;
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@ClientName", c.ClientName);
                cmd.Parameters.AddWithValue("@ClientAddress", c.ClientAddress);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@TechnicalNote", c.TechnicalNote);
               
                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the vslue of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to update data in database from our application
        public bool Update(newrepairClass c)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update date in our Datebase 
                string sql = "UPDATE tbl_newrepair SET ClientName=@ClientName, ClientAddress=@ClientAddress, ContactNo=@ContactNo, TechnicalNote=@TechnicalNote WHERE JobID=@JobID";

                //Create SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@JobID", c.JobID);
                cmd.Parameters.AddWithValue("@ClientName", c.ClientName);
                cmd.Parameters.AddWithValue("@ClientAddress", c.ClientAddress);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@TechnicalNote", c.TechnicalNote);

                //open database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the vslue of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to Delete data from Database
        public bool Delete(newrepairClass c)
        {
            //Creating a default return type and set its value to flase
            bool isSuccess = false;
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql for Delete Data
                string sql = "DELETE tbl_newrepair WHERE JobID=@JobID";
                //Create SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@JobID", c.JobID);

                //open database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch
            {

            }
            finally
            {
                //Class Connction
                conn.Close();
            }
            return isSuccess;
        }

        //Search Data
        public DataTable Search(string key) 
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try 
            {
                string sql = "SELECT * FROM  tbl_newrepair WHERE ClientName LIKE '% " + key + " %' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                
                conn.Close();
            }
            return dt;
        }
    }

}
