using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System.Classes
{
    class supplierDBUtill
    {
        public int SupplierID { get; set; }

        public string SupplierName { get; set; }

        public string BrandName { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DataTable dataTable { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;






        // Selecting Data from Database

        public DataTable Select()
        {
            // Step 1 : Database Connection

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();



            try
            {

                // Step 2 : Writing SQL query
                string sql = "SELECT * FROM tbl_supplier";

                // Creating commant using SQL and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Creating SQL Data Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }



            finally
            {
                conn.Close();
            }

            return dt;


        }






        // Insert Data into Database

        public bool Insert(supplierDBUtill c)
        {


            // Craeting a default return type and setting its value to false
            bool isSuccess = false;



            // Step 1 : Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);



            try
            {
                // Step 2 : Create SQL query to Insert Data
                string sql = "INSERT INTO tbl_supplier (SupplierName, BrandName, ContactNo, Email, Address) VALUES (@SupplierName, @BrandName, @ContactNo, @Email, @Address)";



                //  Creating SQL command using SQL and conn
                SqlCommand cmd = new SqlCommand(sql, conn);



                // Create parameters to add data
                cmd.Parameters.AddWithValue("@SupplierName", c.SupplierName);
                cmd.Parameters.AddWithValue("@BrandName", c.BrandName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Address", c.Address);



                // Connection Open Here
                conn.Open();

                int rows = cmd.ExecuteNonQuery();



                // If the query runs successfully, then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }


            finally
            {
                conn.Close();
            }



            return isSuccess;
        }






        // Update Data in Database from application

        public bool Update(DataTable dt)
        {

            // Craeting a default return type and setting its value to false
            bool isSuccess = false;

            
            SqlConnection conn = new SqlConnection(myconnstrng);


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                try
                {


                    string SupplierID = (string)dt.Rows[i][0];
                    string SupplierName = (string)dt.Rows[i][1];
                    string BrandName = (string)dt.Rows[i][2];
                    string ContactNo = (string)dt.Rows[i][3];
                    string Email = (string)dt.Rows[i][4];
                    string Address = (string)dt.Rows[i][5];

                   


                    // SQL to Update data in Database
                    string sql = "UPDATE tbl_supplier SET SupplierName = @SupplierName, BrandName = @BrandName, ContactNo = @ContactNo, Email = @Email, Address = @Address WHERE SupplierID = @SupplierID";

                    //string sql = "UPDATE tbl_supplier SET SupplierName = @SupplierName, BrandName = @BrandName, ContactNo = @ContactNo, Email = @Email, Address = @Address WHERE SupplierID = @SupplierID ";

                    // Creating SQL Command
                    SqlCommand cmd = new SqlCommand(sql, conn);



                    // Create Parameters to Add Values
                    cmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                    cmd.Parameters.AddWithValue("@BrandName", BrandName);
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@SupplierID",SupplierID);



                    // Connection Open Here
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();



                    // If the query runs successfully, then the value of rows will be greater than zero else its value will be 0
                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }


                }
                catch (Exception e)
                {

                }


                finally
                {
                    conn.Close();
                }
            }

            return isSuccess;
        }






        // Delete Data from Database

        public bool Delete(supplierDBUtill c)
        {


            // Craeting a default return type and setting its value to false
            bool isSuccess = false;



            // Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);



            try
            {
                // Sql to Delete Data
                string sql = "DELETE FROM tbl_supplier WHERE SupplierID = @SupplierID";



                // Create SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("SupplierID", c.SupplierID);



                // Open Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();



                // If the query runs successfully, then the value of rows will be greater than zero else its value will be 0


                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception e)
            {

            }


            finally
            {
                conn.Close();
            }



            return isSuccess;


        }






        // Search Method

        public DataTable Search(string key)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {

                string sql = "SELECT * from  tbl_supplier WHERE SupplierID LIKE '%" + key + "%'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }




        //data retrieve
        public static DataTable supplierMonthlyRep(string date1, string date2)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

           
       



            try
            {
                //sql query
                string sql = "SELECT Name,Brand,SUM(Amount) AS 'Total Amount' FROM tbl_Order_New WHERE Date BETWEEN '" + date1 + "' AND '" + date2 + "' GROUP BY Name,Brand  ORDER BY [Total Amount] DESC";
                
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                


                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                


                conn.Open();


                adapter.Fill(dt);
    

            }
            catch (Exception e)
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






    