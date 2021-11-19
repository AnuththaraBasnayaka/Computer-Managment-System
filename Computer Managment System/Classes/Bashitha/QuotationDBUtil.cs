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
    class QuotationDBUtil
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //DB connection
        static SqlConnection conn = new SqlConnection(myconnstrng);

        public static DataTable Select()
        {
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_Order";

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
        
            public static DataTable SelectQuotationList()
        {
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM Quotation";

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
        public static DataTable SelectBrand()
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT Brand FROM tbl_stock GROUP BY Brand";

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

        public static DataTable SelectCategory(string BrandQ)
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_stock WHERE Brand = '" + BrandQ + "'";

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

        public static DataTable SelectItems(string brand, string category)
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT ItemName FROM tbl_Stock WHERE Brand = '" + brand + "' AND Catogery = '" + category + "'";

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
        //Retrieve Serial Number And UnitPrice of a Item
        public static DataTable SelectItemDetails(string brand, string category,string itemName)
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT SerialNumber, UnitPrice FROM tbl_Stock WHERE Brand= '" + brand + "' AND Catogery = '" + category + "' AND ItemName = '" + itemName + "'";

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
        // Insert Customer Details
        public static bool insertCustomer(Customer c)
        {
            bool isSuccess = false;

            try
            {
                //sql query

               // MessageBox.Show(c.TotalAmount.ToString());
                string sql = "INSERT INTO Quotation (CustomerName, TeleNo, Email, Address, Date, TotalAmount) VALUES(@CustomerName, @TeleNo, @Email, @Address, @Date, @TotalPrice)";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating parameters to add 
                
                cmd.Parameters.AddWithValue("@CustomerName",c.Name);
                cmd.Parameters.AddWithValue("@TeleNo",c.No);
                cmd.Parameters.AddWithValue("@Email",c.Email);
                cmd.Parameters.AddWithValue("@Address",c.Address);
                cmd.Parameters.AddWithValue("@Date",c.Date);
                cmd.Parameters.AddWithValue("@TotalPrice", c.TotalAmount);

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
        //Get QID relavent to Customer
        public static int getQID()
        {
            int qid = 0;


            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT TOP 1 * FROM Quotation ORDER BY QID DESC";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    qid = Convert.ToInt32(dr["QID"].ToString());
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }


            return qid;
        }

        //Insert Quotation Item Details
        public static bool insertQuotationItems(DataTable dt, int Qid)
        {

            bool isSuccess = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {

                    //MessageBox.Show(id.ToString());
                    string serialNo = (string)dt.Rows[i][0];
                    string itemName = (string)dt.Rows[i][1];
                    string qty = (string)dt.Rows[i][2];
                    string unitPrice = (string)dt.Rows[i][3];
                    string total = (string)dt.Rows[i][4];
                    //MessageBox.Show(itemName.ToString());
                    //MessageBox.Show(serialNo.ToString());
                    //sql query
                    string sql = "INSERT INTO QuotationItemDetails(QID, SerialNo, ItemName, Qty, UnitPrice, TotalPrice) VALUES(@QID, @SerialNo, @ItemName, @Qty, @UnitPrice ,@TotalPrice)";
                   // string sql = "INSERT INTO QuotationItemDetails(QID, SerialNo, ItemName, Qty, UnitPrice, TotalPrice) VALUES(@QID, 'va, 'VALUE', @Qty, @UnitPrice ,@TotalPrice)";
                    //creating cmd using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    //creating parameters to add 
                    cmd.Parameters.AddWithValue("@QID", Qid);
                    cmd.Parameters.AddWithValue("@SerialNo", serialNo);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Qty", qty);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@TotalPrice", total);

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

        public static void SelectQuotation(ref DataTable QuotationItemDT, ref DataTable CustomerDT, int qid)
        {
            try
            {

                //sql query
                //MessageBox.Show(qid.ToString());
                string sql_1 = "SELECT * FROM QuotationItemDetails WHERE QID = '" + qid + "'";
                string sql_2 = "SELECT * FROM Quotation WHERE QID = '" + qid + "'";


                //creating cmd using sql and conn
                SqlCommand cmd_1 = new SqlCommand(sql_1, conn);
                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter_1 = new SqlDataAdapter(cmd_1);
                SqlDataAdapter adapter_2 = new SqlDataAdapter(cmd_2);

                conn.Open();

                adapter_1.Fill(QuotationItemDT);
                adapter_2.Fill(CustomerDT);


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

        }
        public static bool UpdateQuotationItems(Quotation q)
        {
            bool isSuccess = false;

            DataTable dt = new DataTable();
            dt = q.dataTable;




            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {

                    string id = (string)dt.Rows[i][0];
                    string serialNo = (string)dt.Rows[i][2];
                    string itemName = (string)dt.Rows[i][3];
                    string qty = (string)dt.Rows[i][4];
                    string unitPrice = (string)dt.Rows[i][5];
                    string totalprice = (string)dt.Rows[i][6];
                    string QID = (string)dt.Rows[i][1];
                   // MessageBox.Show(id);
                   // MessageBox.Show(serialNo);
                   // MessageBox.Show(itemName);
                    //sql query
                    string sql = "UPDATE QuotationItemDetails SET SerialNo=@serialNo, ItemName=@itemName, Qty=@qty, UnitPrice=@unitPrice, TotalPrice =@totalprice WHERE QID=@QID AND id=@id";

                    //creating cmd using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    //creating parameters to add 
                    cmd.Parameters.AddWithValue("@QID", QID);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@serialNo", serialNo);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@totalprice", totalprice);



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







        public static bool quotationUpdate(Quotation q)
        {
            bool isSuccess = false;


            try
            {

                //sql query
                string sql = "UPDATE Quotation SET TotalAmount=@totAmount WHERE QID=@qid ";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);


                //creating parameters to add 
                cmd.Parameters.AddWithValue("@qid", q.QID);
                cmd.Parameters.AddWithValue("@totAmount", q.TotalAmount);




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














        public static bool Delete(int id)
        {
            bool isSuccess = false;

            try
            {


                string sql_1 = "DELETE FROM Quotation WHERE QID=@id";
                string sql_2 = "DELETE FROM QuotationItemDetails WHERE QID=@id";





                //creating cmd using sql and conn
                SqlCommand cmd_1 = new SqlCommand(sql_1, conn);
                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);


                cmd_1.Parameters.AddWithValue("@id", id);
                cmd_2.Parameters.AddWithValue("@id", id);

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




        public static void SelectReport(ref DataTable reportDT)
        {

            try
            {
                //sql query
                string sql = "SELECT COUNT(Qty) AS Quantity,ItemName  FROM QuotationItemDetails GROUP BY ItemName ORDER BY Quantity DESC ";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(reportDT);


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

        }


        public static DataTable SearchCustomer(string name)
        {

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM Quotation WHERE CustomerName LIKE '%" + name + "%'";

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
