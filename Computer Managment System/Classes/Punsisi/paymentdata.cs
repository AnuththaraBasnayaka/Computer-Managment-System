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
    class paymentdata
    {
        //Getter Setter properties
        //Acts as Data carrier in Application

        public int PaymentID { get; set; }
        public string EmployeeID { get; set; }
        public string NIC { get; set; }
        public string PayDate { get; set; }
        public string PayMonth { get; set; }
        public double ContractualHour { get; set; }
        public double OvertimeHour { get; set; }
        public double ContractualRate { get; set; }
        public double OvertimeRate { get; set; }
        public double TotalHour { get; set; }
        public double ContractualEarning { get; set; }
        public double OvertimeEarning { get; set; }
        public double TotalPay { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Selecting data from data base

        public DataTable Select()
        {
            //Step01: Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step02: Writing Sql Query
                string sql = "SELECT * FROM tbl_salary";
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

        //Inserting data into database
        public bool Insert(paymentdata p)
        {
            //Creating a default return type and setting its value to false
            bool isSucces = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2: Create a SQL query to insert data
                string sql = "INSERT INTO tbl_salary (PayID,E_ID,NIC,payDate,payMonth,con_Hour,over_Hour,con_Rate,over_Rate,tot_Hour,con_Earn,over_Earn,tot_Earn) VALUES (@PayID,@EmpID,@nic,@payDate,@payMonth,@con_Hour,@over_Hour,@con_Rate,@over_Rate,@tot_Hour,@con_Earn,@over_Earn,@tot_Earn)";
                
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating Parameter to add data

                cmd.Parameters.AddWithValue("@PayID", p.PaymentID);
                cmd.Parameters.AddWithValue("@EmpID", p.EmployeeID);
                cmd.Parameters.AddWithValue("@nic", p.NIC);
                cmd.Parameters.AddWithValue("@payDate", p.PayDate);
                cmd.Parameters.AddWithValue("@payMonth", p.PayMonth);
                cmd.Parameters.AddWithValue("@con_Hour", p.ContractualHour);
                cmd.Parameters.AddWithValue("@over_Hour", p.OvertimeHour);
                cmd.Parameters.AddWithValue("@con_Rate", p.ContractualRate);
                cmd.Parameters.AddWithValue("@over_Rate", p.OvertimeRate);
                cmd.Parameters.AddWithValue("@tot_Hour", p.TotalHour);
                cmd.Parameters.AddWithValue("@con_Earn", p.ContractualEarning);
                cmd.Parameters.AddWithValue("@over_Earn", p.OvertimeEarning);
                cmd.Parameters.AddWithValue("@tot_Earn", p.TotalPay);

                //Open database connection here
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
        public bool Update(paymentdata p)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                //SQL to update in database
                string sql = "UPDATE tbl_salary SET PayID=@PayID, E_ID=@EmpID, NIC=@nic, payDate=@payDate, payMonth=@payMonth, con_Hour=@con_Hour, over_Hour=@over_Hour, con_Rate=@con_Rate,over_Rate=@over_Rate, tot_Hour=@tot_Hour, con_Earn=@con_Earn, over_Earn=@over_Earn, tot_Earn=@tot_Earn  WHERE PayID=@PayID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create {+Parameters to add value

                cmd.Parameters.AddWithValue("@PayID", p.PaymentID);
                cmd.Parameters.AddWithValue("@EmpID", p.EmployeeID);
                cmd.Parameters.AddWithValue("@nic", p.NIC);
                cmd.Parameters.AddWithValue("@payDate", p.PayDate);
                cmd.Parameters.AddWithValue("@payMonth", p.PayMonth);
                cmd.Parameters.AddWithValue("@con_Hour", p.ContractualHour);
                cmd.Parameters.AddWithValue("@over_Hour", p.OvertimeHour);
                cmd.Parameters.AddWithValue("@con_Rate", p.ContractualRate);
                cmd.Parameters.AddWithValue("@over_Rate", p.OvertimeRate);
                cmd.Parameters.AddWithValue("@tot_Hour", p.TotalHour);
                cmd.Parameters.AddWithValue("@con_Earn", p.ContractualEarning);
                cmd.Parameters.AddWithValue("@over_Earn", p.OvertimeEarning);
                cmd.Parameters.AddWithValue("@tot_Earn", p.TotalPay);

                //Open data base connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be zero
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

        public bool Delete(paymentdata p)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;
            //Create sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to delete data
                string sql = "DELETE FROM tbl_salary WHERE PayID=@PayID";

                //Create SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PayID", p.PaymentID);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query run Successfully then the value of rows is greater than zero else its value is 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {

                //close the connection
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable Search(string key)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_salary WHERE E_ID LIKE '%" + key + "%'";
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


        public static string GetEmployeeName(string E_Id)
        {
            string employeename = null;

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_Employee WHERE E_ID = '" + E_Id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    employeename = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();

                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return employeename;
        }
    }
}
