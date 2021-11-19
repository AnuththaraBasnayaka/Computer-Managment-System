using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Managment_System.Classes.Anuththara
{
    class repairsearchClass
    {
        public string CusName { get; set; }
        public DateTime DateTime { get; set; }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;



        //Find the billing date of a customer
        public static DataTable SearchbillDate(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query to get customer name and date
                string sql = "SELECT InvoiceId , CusName , CusMobile , DateTime FROM tbl_invoice WHERE CusName LIKE '%" + key + "%' OR InvoiceId LIKE '%" + key + "%' ";

                //create the cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open sql connection
                conn.Open();

                adapter.Fill(dt);


            }
            catch (Exception e)
            {

            }
            finally
            {
                //close sql connection
                conn.Close();
            }


            return dt;
        }


        //Find the warranty period of an Item
        public static DataTable SearchWarranty(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query to get warranty details
                string sql = "SELECT InvoiceId , SerialNumber , Item , Warranty FROM tbl_invoiceItems WHERE SerialNumber LIKE '%" + key + "%' OR Item LIKE '%" + key + "%' OR InvoiceId LIKE '%" + key + "%' ";

                //create the cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open sql connection
                conn.Open();

                adapter.Fill(dt);


            }
            catch (Exception e)
            {

            }
            finally
            {
                //close sql connection
                conn.Close();
            }


            return dt;
        }

        //Find the warranty period of an Item
        public static DataTable repairDetSearch(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query to get warranty details
                string sql = "SELECT * FROM tbl_newrepair WHERE ClientName LIKE '%" + key + "%' OR TechnicalNote LIKE '%" + key + "%'";

                //create the cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open sql connection
                conn.Open();

                adapter.Fill(dt);


            }
            catch (Exception e)
            {

            }
            finally
            {
                //close sql connection
                conn.Close();
            }


            return dt;
        }

        //Find the warranty period of an Item
        public static DataTable searviceDetSearch(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query to get warranty details
                string sql = "SELECT * FROM tbl_status WHERE ServiceID LIKE '%" + key + "%' OR ServiceName LIKE '%" + key + "%'";

                //create the cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open sql connection
                conn.Open();

                adapter.Fill(dt);


            }
            catch (Exception e)
            {

            }
            finally
            {
                //close sql connection
                conn.Close();
            }


            return dt;
        }

        //Find the warranty period of an Item
        public static DataTable statusDetSearch(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query to get warranty details
                string sql = "SELECT * FROM tbl_status WHERE ServiceName LIKE '%" + key + "%' AND  ServiceType = 'On'";

                //create the cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open sql connection
                conn.Open();

                adapter.Fill(dt);


            }
            catch (Exception e)
            {

            }
            finally
            {
                //close sql connection
                conn.Close();
            }


            return dt;
        }
    }
}
