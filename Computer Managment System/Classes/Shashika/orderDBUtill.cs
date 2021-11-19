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
    class orderDBUtill
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //DB connection
        static SqlConnection conn = new SqlConnection(myconnstrng);



        //data retrieve
        public static DataTable Select()
        {
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_Order_New";

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



        //Select brands
        public static DataTable SelectBrand()
        {
            DataTable dt = new DataTable();
            
            try
            {

                //sql query
                string sql = "SELECT brandName FROM tbl_Supplier GROUP BY brandName";
                
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


        //Select Suppliers
        public static DataTable SelectSuppliers(string brand)
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_Supplier WHERE brandName = '"+ brand +"'";

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

        public static DataTable SelectCategory()
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT Catogery FROM tbl_Stock GROUP BY Catogery";

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



        //Select Item names
        public static DataTable SelectItems(string brand, string cat)
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT ItemName FROM tbl_Stock WHERE Brand = '"+brand+"' AND Catogery = '"+cat+"'";

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




        //Select Item row
        public static DataTable SelectRows(string brand, string cat, string itemName)
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT SerialNumber, UnitPrice FROM tbl_Stock WHERE Brand = '" + brand + "' AND Catogery = '" + cat + "' AND itemName = '"+itemName+"'";

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






        //get supplierID
        public static string getSid(string name, string brand)
        {
            string sid = null;
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT SupplierID FROM tbl_Supplier WHERE BrandName = '" + brand + "' AND SupplierName = '" + name + "'";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    sid = dr["SupplierID"].ToString();
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return sid;

        }






        //insert order Details
        public static bool insert(Order o)
        {
            bool isSuccess = false;

            try
            {
                //sql query
                string sql = "INSERT INTO tbl_Order_New(Date, SID, Name, Brand, Amount, Status) VALUES(@Date, @SID, @Name, @Brand, @Amount, @Status)";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating parameters to add 
                cmd.Parameters.AddWithValue("@Date", o.date);
                cmd.Parameters.AddWithValue("@SID", o.sid);
                cmd.Parameters.AddWithValue("@Name", o.name);
                cmd.Parameters.AddWithValue("@Brand", o.brand);
                cmd.Parameters.AddWithValue("@Amount", o.tot);
                cmd.Parameters.AddWithValue("@Status", o.status);

                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }



            } catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }






        //get last Order ID
        public static int getOrderID()
        {
            int id = 0;

            
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT TOP 1 * FROM tbl_Order_New ORDER BY OrderID DESC";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    id = Convert.ToInt32(dr["OrderID"].ToString());
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }


            return id;
        }








        //insert order item details
        public static bool insertOrderItems(DataTable dt, int id)
        {
           
            bool isSuccess = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {

                   
                    string serialNo = (string)dt.Rows[i][0];


                    string iName = (string)dt.Rows[i][1];
                    string qty = (string)dt.Rows[i][2];
                    string unitPrice = (string)dt.Rows[i][3];


                    //sql query
                    string sql = "INSERT INTO tbl_OrderItems(orderID, serialNo, itemName, qty, unitPrice) VALUES(@orderID, @serialNo, @itemName, @qty, @unitPrice)";

                    //creating cmd using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    //creating parameters to add 
                    cmd.Parameters.AddWithValue("@orderID", id);
                    cmd.Parameters.AddWithValue("@serialNo", serialNo);
                    cmd.Parameters.AddWithValue("@itemName", iName);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);

                    //connection open here
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

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
            }

            return isSuccess;
        }








       


        public static void SelectOrder(ref DataTable orderDT, ref DataTable itemDT, int oid)
        {
            

            try
            {

                //sql query
                string sql_1 = "SELECT * FROM tbl_OrderItems WHERE orderID = '" + oid + "'";
                string sql_2 = "SELECT * FROM tbl_Order_New WHERE OrderID = '" + oid + "'";


                //creating cmd using sql and conn
                SqlCommand cmd_1 = new SqlCommand(sql_1, conn);
                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter_1 = new SqlDataAdapter(cmd_1);
                SqlDataAdapter adapter_2 = new SqlDataAdapter(cmd_2);

                conn.Open();

                adapter_1.Fill(itemDT);
                adapter_2.Fill(orderDT);


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

           
        }







        public static bool UpdateOrderItems(Order o)
        {
            bool isSuccess = false;

            DataTable dt = new DataTable();
            dt = o.dataTable;

          


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {

                    string id = (string)dt.Rows[i][0];
                    string serialNo = (string)dt.Rows[i][2];
                    string iName = (string)dt.Rows[i][3];
                    string qty = (string)dt.Rows[i][4];
                    string unitPrice = (string)dt.Rows[i][5];


                    //sql query
                    string sql = "UPDATE tbl_OrderItems SET serialNo=@serialNo, itemName=@itemName, qty=@qty, unitPrice=@unitPrice WHERE id=@id AND orderID=@orderID ";

                    //creating cmd using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    //creating parameters to add 
                    cmd.Parameters.AddWithValue("@orderID", o.orderID);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@serialNo", serialNo);
                    cmd.Parameters.AddWithValue("@itemName", iName);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);



                    //connection open here
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

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
            }
            

            return isSuccess;
        }












        public static bool updateTot(Order o)
        {
            bool isSuccess = false;

          
                try
                {
   
                    //sql query
                    string sql = "UPDATE tbl_Order_New SET Amount=@tot WHERE OrderID=@orderID ";

                    //creating cmd using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    //creating parameters to add 
                    cmd.Parameters.AddWithValue("@orderID", o.orderID);
                    cmd.Parameters.AddWithValue("@tot", o.tot);
                    



                    //connection open here
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

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





        public static bool Delete(Order o)
        {
            bool isSuccess = false;
          
            try
            {
               

                string sql_1 = "DELETE FROM tbl_OrderItems WHERE orderID=@id";
                string sql_2 = "DELETE FROM tbl_Order_New WHERE OrderID=@id";


              


                //creating cmd using sql and conn
                SqlCommand cmd_1 = new SqlCommand(sql_1, conn);
                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);


                cmd_1.Parameters.AddWithValue("@id", o.orderID);
                cmd_2.Parameters.AddWithValue("@id", o.orderID);

                //connection open here
                conn.Open();
                int rows_1 = cmd_1.ExecuteNonQuery();
                int rows_2 = cmd_2.ExecuteNonQuery();

                if (rows_1 > 0 && rows_2 > 0)
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















        //Search data
        public static DataTable Search(string key)
        {

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_Order_New WHERE Name LIKE '%" + key + "%' OR Brand LIKE '%" + key + "%' OR Status LIKE '%" + key + "%' OR OrderID LIKE '%" + key + "%'";

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







        //get Supplier Details

        public static void getSupplier(ref supplier s)
        {

           
            int sid = Convert.ToInt32(s.supplierID);

            DataTable dt = new DataTable();
            
            try
            {
                
                //sql query
                string sql = "SELECT * FROM tbl_supplier WHERE SupplierID = '" + sid + "'";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
                
                
                foreach (DataRow dr in dt.Rows)

                {
                    
                    s.name = dr["SupplierName"].ToString();
                    s.no = dr["ContactNo"].ToString();
                    s.email = dr["Email"].ToString();
                    s.address = dr["Address"].ToString();
                    
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






        public static bool completeOrder(Order o)
        {
            bool isSuccess = false;
            o.status = "Completed";

            try
            {



                //sql query
                string sql = "UPDATE tbl_Order_New SET Status=@Status WHERE OrderID=@orderID ";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);


                //creating parameters to add 
                cmd.Parameters.AddWithValue("@orderID", o.orderID);
                cmd.Parameters.AddWithValue("@Status", o.status);
                



                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

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





        //get Print data
        public static DataTable ordersMonthlyReport(string date1, string date2)
        {
            

            DataTable dt = new DataTable();



            try
            {
                //sql query
                string sql = "SELECT Brand, Count(Brand) AS 'Number of Orders' , SUM(Amount) AS 'Total' FROM tbl_Order_New WHERE Date BETWEEN '" + date1 + "' AND '" + date2 + "' GROUP BY Brand  ORDER BY [Number of Orders] DESC";

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



        

        

    


    




