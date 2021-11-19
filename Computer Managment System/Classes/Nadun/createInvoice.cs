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
    class createInvoice
    {
        //getter and setter properties
        //act as data carrier in our application
        public string SerialNumber { get; set; }
        public DataTable dataTable { get; set; }
        public string CusName { get; set; }
        public int CusMobile { get; set; }
        public float TotalDiscount { get; set; }
        public float Total { get; set; }
        public float Receive { get; set; }
        public float Change { get; set; }
        //public int inid { get; set; }
        public string date { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //step:1 database connection
        static SqlConnection conn = new SqlConnection(myconnstrng);


/*
************************************************************************************BILLING_FORM_METHODS**************************************************************************************
*/


    //insert data into database
    public bool Insert(createInvoice c)
        {
            //creating default return type and setting its value to false
            bool isSuccess = false;

            //step1 connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //MessageBox.Show(c.date);
                //step 2 create a sql query to insert data
                string sql = "INSERT INTO tbl_invoice(CusName,CusMobile,DateTime,TotalDiscount,Total,Receive,Change)VALUES(@CusName,@CusMobile,@DateTime,@TotalDiscount,@Total,@Receive,@Change)";
                //string sql = "INSERT INTO tbl_invoice (CusName,CusMobile,TotalDiscount,Total,Receive,Change)VALUES('nadun',0125,200,20000,50000,30000)";

                //creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameter to add data
                cmd.Parameters.AddWithValue("@CusName", c.CusName);
                cmd.Parameters.AddWithValue("@CusMobile", c.CusMobile);
                cmd.Parameters.AddWithValue("@DateTime", c.date);
                cmd.Parameters.AddWithValue("@TotalDiscount", c.TotalDiscount);
                cmd.Parameters.AddWithValue("@Total", c.Total);
                cmd.Parameters.AddWithValue("@Receive", c.Receive);
                cmd.Parameters.AddWithValue("@Change", c.Change);

                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query runs successfully then the value of rows will be greater than zero else its value will be 0
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


        //Select Item row
        public static DataTable SelectRow(string SerialNumber)
        {
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT ItemName, SellingPrice, Warranty, ItemQuantity  FROM tbl_Stock WHERE SerialNumber = '"+SerialNumber+"' " ;

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

        public static bool UpdateOrderItems(DataTable dt)
        {
            bool isSuccess = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    string Id = (string)dt.Rows[i][0];
                    //string InvoiceId = (string)dt.Rows[i][1];
                    //string SerialNumber = (string)dt.Rows[i][2];
                    string Item = (string)dt.Rows[i][3];
                    string Qty = (string)dt.Rows[i][4];
                    string UnitPrice = (string)dt.Rows[i][5];
                    string ManualDiscount = (string)dt.Rows[i][6];
                    string SubTotal = (string)dt.Rows[i][7];
                    string Warranty = (string)dt.Rows[i][8];

                    //sql query
                    string sql = "UPDATE tbl_invoiceItems SET Item=@Item, Qty=@Qty, UnitPrice=@UnitPrice, ManualDiscount=@ManualDiscount, SubTotal=@SubTotal, Warranty=@Warranty WHERE Id=@Id";

                    //creating cmd using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    //creating parameters to add 
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Item",Item);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    cmd.Parameters.AddWithValue("@ManualDiscount", ManualDiscount);
                    cmd.Parameters.AddWithValue("@SubTotal", SubTotal );
                    cmd.Parameters.AddWithValue("@Warranty", Warranty);



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

        //get last Order ID
        public static int getInvoiceId()
        {
            int id = 0;


            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT TOP 1 * FROM tbl_invoice ORDER BY invoiceId DESC";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    id = Convert.ToInt32(dr["InvoiceId"].ToString());
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



        //insert saved data table to invoiceItems table
        public static bool insertOrderItems(DataTable dt, int id)
        {

            bool isSuccess = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {

                   // MessageBox.Show(id.ToString());
                    string SerialNumber = (string)dt.Rows[i][0];
                    string Item = (string)dt.Rows[i][1];
                    string UnitPrice = (string)dt.Rows[i][2];
                    string ManualDiscount = (string)dt.Rows[i][3];
                    string Qty = (string)dt.Rows[i][4];
                    string SubTotal = (string)dt.Rows[i][5];
                    string Warranty = (string)dt.Rows[i][6];
                    //sql query
                    string sql = "INSERT INTO tbl_invoiceItems (InvoiceId, SerialNumber, Item, Qty, UnitPrice, ManualDiscount, SubTotal, Warranty) VALUES(@InvoiceId, @SerialNumber, @Item, @Qty, @UnitPrice, @ManualDiscount, @SubTotal, @Warranty)";

                    //creating cmd using sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    //creating parameters to add 
                    cmd.Parameters.AddWithValue("@InvoiceId", id);
                    cmd.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                    cmd.Parameters.AddWithValue("@Item", Item);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    cmd.Parameters.AddWithValue("@ManualDiscount", ManualDiscount);
                    cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                    cmd.Parameters.AddWithValue("@Warranty", Warranty);
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

        internal void Show()
        {
            throw new NotImplementedException();
        }

//********************************************************************************BILL LINEUP FORM**************************************************************************************

        //data retrieve in to billLineUp table
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_invoice";

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

        /*//get invoice id for view
        public static int getinid()
        {
            int id = 0;


            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_invoice ORDER BY Ord";

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
        */
        //data retrieve in to detailBill table
        public static DataTable Select2( int inid)
        {
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM tbl_invoiceItems WHERE invoiceId = '"+ inid +"'";

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
        //Delete invoices from data base
        public bool Remove(int inid)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            MessageBox.Show(inid.ToString());
            try
            {
                string sql_1 = "DELETE FROM tbl_invoice WHERE InvoiceId=@InvoiceId";
                string sql_2 = "DELETE FROM tbl_invoiceItems WHERE InvoiceId=@InvoiceId";

                SqlCommand cmd_1 = new SqlCommand(sql_1, conn);
                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);

                cmd_1.Parameters.AddWithValue("@InvoiceId", inid);
                cmd_2.Parameters.AddWithValue("@InvoiceId", inid);


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
            catch (Exception ex)
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
                string sql = "SELECT * FROM tbl_invoice WHERE InvoiceId LIKE '%" + key + "%'";

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




        //Report genaration functions
        internal static DataTable reportCalc(string date)
        {
            //public static DataTable reportCalc(String date)

            DataTable dt1 = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_invoice WHERE DateTime = '" + date + "'";
               // string sql = "SELECT * FROM tbl_invoice WHERE DateTime = '2021 - 10 - 10'";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt1);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt1;
        }



        public static string calInvoiceTot (string date)
        {

            string totInvoice = null;

            DataTable dtInvoice = new DataTable();



            try
            {
                //sql query
                string sql = "SELECT SUM(Total) AS totInvoice FROM tbl_invoice AS totInvoice WHERE DateTime = '" + date + "'";




                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                


                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                


                conn.Open();

                adapter.Fill(dtInvoice);

                foreach (DataRow dr in dtInvoice.Rows)
                {
                    totInvoice = dr["totInvoice"].ToString();

                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return totInvoice;

        }




    }
}

