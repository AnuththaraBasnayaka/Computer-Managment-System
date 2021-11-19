using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Managment_System.Classes.Dimuthu
{
    class StockData
    {
        //Getters and Setters 
        //Acts as Data carrier in Application

        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int Warranty { get; set; }
        public string ItemDetails { get; set; }
        public float SellingPrice { get; set; }
        public float UnitPrice { get; set; }
        public int ItemQuantity { get; set; }


        //get the database connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Select data from the Item detail table

        public DataTable Selecttbl()
        {
            // make the database connection first
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //next Write the Sql Query to select data from stock table
                string sql = "SELECT * FROM tbl_stock";
                //creating cmd using sql and conn
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


        //Select data from quantity table

        public DataTable SelecttblQ()
        {
            // make the database connection first
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //next Write the Sql Query to select data from 
                string sql = "SELECT * FROM tbl_quantity";
                //creating cmd using sql and conn
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

        internal static void SelectAvailability(ref DataTable availabilityTbl, object itemQuantity)
        {
            throw new NotImplementedException();
        }

        //add item data into the stock table
        public bool InsertItem(StockData s)
        {
            //Creating a default return type and setting its value to false
            bool isSucces = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2: Create a SQL query to insert data
                string sql = "insert into tbl_stock values(@SerialNumber, @ItemName, @Catogery, @Brand, @Warranty, @ItemDetails, @SellingPrice, @UnitPrice, @ItemQuantity)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters for data
                cmd.Parameters.AddWithValue("@SerialNumber", s.SerialNumber);
                cmd.Parameters.AddWithValue("@ItemName", s.ItemName);
                cmd.Parameters.AddWithValue("@Catogery", s.Category);
                cmd.Parameters.AddWithValue("@Brand", s.Brand);
                cmd.Parameters.AddWithValue("@Warranty", s.Warranty);
                cmd.Parameters.AddWithValue("@ItemDetails", s.ItemDetails);
                cmd.Parameters.AddWithValue("@SellingPrice", s.SellingPrice);
                cmd.Parameters.AddWithValue("@UnitPrice", s.UnitPrice);
                cmd.Parameters.AddWithValue("@ItemQuantity", s.ItemQuantity);

                //Open the database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the values of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {

                conn.Close();
            }
            return isSucces;

        }

        //Method to update data in database from application
        public bool UpdateItems(StockData s)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                //SQL query to update Item data in the database
                string sql = "UPDATE tbl_stock SET SerialNumber = @SerialNumber, ItemName = @ItemName, Catogery = @Catogery, Brand = @Brand, Warranty = @Warranty, ItemDetails = @ItemDetails, SellingPrice = @SellingPrice, UnitPrice = @UnitPrice, ItemQuantity = @ItemQuantity  WHERE SerialNumber = @SerialNumber";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters for data
                cmd.Parameters.AddWithValue("@SerialNumber", s.SerialNumber);
                cmd.Parameters.AddWithValue("@ItemName", s.ItemName);
                cmd.Parameters.AddWithValue("@Catogery", s.Category);
                cmd.Parameters.AddWithValue("@Brand", s.Brand);
                cmd.Parameters.AddWithValue("@Warranty", s.Warranty);
                cmd.Parameters.AddWithValue("@ItemDetails", s.ItemDetails);
                cmd.Parameters.AddWithValue("@SellingPrice", s.SellingPrice);
                cmd.Parameters.AddWithValue("@UnitPrice", s.UnitPrice);
                cmd.Parameters.AddWithValue("@ItemQuantity", s.ItemQuantity);


                //Open data base connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the values of rows will be greater than zero else its value will be 0
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

        //Method to Delete data from Database stock table

        public bool DeleteItem(StockData s)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;
            //Create sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                //SQL to delete data from Item table
                string sql = "DELETE FROM tbl_stock WHERE SerialNumber = @SerialNumber";

                //Create SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SerialNumber", s.SerialNumber);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query run Successfully then the value of rows is greater than zero else its value is 0
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

                //close the connection
                conn.Close();
            }
            return isSuccess;
        }


        //Search data from Item table
        public static DataTable SearchItem(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_stock WHERE SerialNumber LIKE '%" + key + "%' OR Catogery LIKE '%" + key + "%' OR ItemName LIKE '%" + key + "%' OR Brand LIKE '%" + key + "%'";

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

        //search data from quantity table

        public static DataTable SearchQuantity(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_quantity WHERE ItemID LIKE '%" + key + "%' OR Availability LIKE '%" + key + "%' OR SerialNumber LIKE '%" + key + "%' OR ItemQuantity LIKE '%" + key + "%'";

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

        //Select Item Availability
        public static void SelectAvailability( ref DataTable AvailabilityTbl, int Quantity)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_stock WHERE ItemQuantity = '" + Quantity + "'";


                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(AvailabilityTbl);


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }


        }

        //search Item data by category
        public static DataTable SearchByCategory(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT SerialNumber, ItemName, Catogery, Brand, ItemQuantity FROM tbl_stock WHERE Catogery LIKE '%" + key + "%'";

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

        //search for all item data by catogery
        public static DataTable GetItemData(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_stock WHERE Catogery LIKE '%" + key + "%'";

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

        //search data from orderTable
        public static DataTable SearchOrderItemDet(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_OrderItems WHERE serialNo LIKE '%" + key + "%' OR itemName LIKE '%" + key + "%'";

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
