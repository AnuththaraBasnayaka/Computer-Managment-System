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
    class Financial
    {


        public string totSal { get; set; }
        public string totInvoices { get; set; }
        public string totOrders { get; set; }







        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //DB connection
        static SqlConnection conn = new SqlConnection(myconnstrng);






        //data retrieve
        public static Financial financialCalc(string date1, string date2)
        {

            Financial ft = new Financial();

            string totSal = null;
            string totOrder = null;
            string totInvoice = null;


            int iTot = 0;


            DataTable dtSal = new DataTable();
            DataTable dtOrder = new DataTable();
            DataTable dtInvoice = new DataTable();


          
            try
            {
                //sql query
                string sql_1 = "SELECT SUM(tot_Earn) AS totSal FROM tbl_salary WHERE payDate BETWEEN '" + date1 + "' AND '" + date2 + "'";
                string sql_2 = "SELECT SUM(Amount) AS  totOrder FROM tbl_Order_New WHERE Date BETWEEN '" + date1 + "' AND '" + date2 + "'";
                string sql_3 = "SELECT SUM(Total) AS totInvoice FROM tbl_invoice WHERE DateTime BETWEEN '" + date1 + "' AND '" + date2 + "'";

               


                //creating cmd using sql and conn
                SqlCommand cmd_1 = new SqlCommand(sql_1, conn);
                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);
                SqlCommand cmd_3 = new SqlCommand(sql_3, conn);

        
                //creating sql data adapter using cmd
                SqlDataAdapter adapter_1 = new SqlDataAdapter(cmd_1);
                SqlDataAdapter adapter_2 = new SqlDataAdapter(cmd_2);
                SqlDataAdapter adapter_3 = new SqlDataAdapter(cmd_3);

             
                conn.Open();

               
                adapter_1.Fill(dtSal);
                adapter_2.Fill(dtOrder);
                adapter_3.Fill(dtInvoice);


                foreach (DataRow dr in dtOrder.Rows)
                {                           
                    ft.totOrders = dr["totOrder"].ToString();                
                }

                
                foreach (DataRow dr in dtSal.Rows)
                {
                    ft.totSal = dr["totSal"].ToString();
                }


                foreach (DataRow dr in dtInvoice.Rows)
                {
                    ft.totInvoices = dr["totInvoice"].ToString();
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return ft;

        }


    }
}
