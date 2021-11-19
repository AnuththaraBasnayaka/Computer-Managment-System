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
    class servicestatusClass
    {
        //Geter and Service Properties
        //Acts as Data Carries in our Application 
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public string ServiceOwner { get; set; }
        public string Duration { get; set; }



        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Selcting Data from Database
        public DataTable Select()
        {
            //step01 : Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM tbl_status";
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
        public bool Insert(servicestatusClass s)
        {
            //Creating a default return type and set its value to flase
            bool isSuccess = false;
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2; Create a SQL Query to insert Date
                string sql = "INSERT INTO tbl_status (ServiceName, ServiceType,  ServiceOwner, Duration)VALUES(@ServiceName, @ServiceType, @ServiceOwner, @Duration)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@ServiceName", s.ServiceName);
                cmd.Parameters.AddWithValue("@ServiceType", s.ServiceType);
                cmd.Parameters.AddWithValue("@ServiceOwner", s.ServiceOwner);
                cmd.Parameters.AddWithValue("@Duration", s.Duration);


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
        public bool Update(servicestatusClass s)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update date in our Datebase 
                string sql = "UPDATE tbl_status SET ServiceName=@ServiceName, ServiceType=@ServiceType, ServiceOwner=@ServiceOwner, Duration=@Duration WHERE ServiceID=@ServiceID";

                //Create SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@ServiceID", s.ServiceID);
                cmd.Parameters.AddWithValue("@ServiceName", s.ServiceName);
                cmd.Parameters.AddWithValue("@ServiceType", s.ServiceType);
                cmd.Parameters.AddWithValue("@ServiceOwner", s.ServiceOwner);
                cmd.Parameters.AddWithValue("@Duration", s.Duration);


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
        public bool Delete(servicestatusClass s)
        {
            //Creating a default return type and set its value to flase
            bool isSuccess = false;
            //Step1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql for Delete Data
                string sql = "DELETE tbl_status WHERE ServiceID = @ServiceID";
                //Create SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@ServiceID", s.ServiceID);

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

        //generate service repair report to retrieve available services
        public static void SelectServices(ref DataTable ServiceTbl)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_status WHERE ServiceType = 'On'";


                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(ServiceTbl);


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }


        }
    }
}
