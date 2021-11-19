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
    class EmployeeDetails
    {
        public int A_ID { get; set; }

        public string AccountType { get; set; }

        public string E_ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string NIC { get; set; }

        public string MobileNo { get; set; }

        public string Email { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DataTable dataTable { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        


        //Selecting Data from Database
        public DataTable Select()
        {
            ///Step 1: Data Base Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();



            try
            {
                ////Step 2: Writing SQL Query
                string sql = "SELECT * FROM tbl_Employee";

                ////Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                ////Creating SQL DataAapter using cmd
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









        //Inseting Data into Database
        public bool Insert(EmployeeDetails c)
        {


            //creating a default return type and setting value to false
            bool isSuccess = false;

            //Step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {



                //Step 2: SQL Quary to insert Data
                string sql = "INSERT INTO tbl_Employee (AccountType,E_ID, FirstName, LastName, Address, NIC, MobileNo, Email, DOB, Gender, UserName, Password) VALUES (@AccountType, @E_ID, @FirstName, @LastName, @Address, @NIC, @MobileNo, @Email, @DOB, @Gender, @UserName, @Password)";
                

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);


                //Create Parameter to add data
                cmd.Parameters.AddWithValue("@AccountType", c.AccountType);
                cmd.Parameters.AddWithValue("@E_ID", c.E_ID);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@NIC", c.NIC);
                cmd.Parameters.AddWithValue("@MobileNo", c.MobileNo);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@DOB", c.DOB);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@UserName", c.UserName);
                cmd.Parameters.AddWithValue("@Password", c.Password);



                //Connection open here
                conn.Open();

                int rows = cmd.ExecuteNonQuery();


                //If the quary runs successfully then the value of rows will be greater than zero else its value will be 0
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


        //Metord to update data in database from our appication
        public static bool Update(EmployeeDetails c)
        {
            bool isSuccess = false;

            DataTable dt = new DataTable();
            dt = c.dataTable;


            SqlConnection conn = new SqlConnection(myconnstrng);



            for(int i = 0;i < dt.Rows.Count;i++ )
            { 

                 try
                    {
                    string A_ID = (string)dt.Rows[i][0];
                    string AccountType = (string)dt.Rows[i][1];
                    string E_ID = (string)dt.Rows[i][2];
                    string FirstName = (string)dt.Rows[i][3];
                    string LastName = (string)dt.Rows[i][4];
                    string Address = (string)dt.Rows[i][5];
                    string NIC = (string)dt.Rows[i][6];
                    string MobileNo = (string)dt.Rows[i][7];
                    string Email = (string)dt.Rows[i][8];
                    string DOB = (string)dt.Rows[i][9];
                    string Gender = (string)dt.Rows[i][10];
                    string UserName = (string)dt.Rows[i][11];
                    string Password = (string)dt.Rows[i][12];  



                    string sql = "UPDATE tbl_Employee SET AccountType = @AccountType ,E_ID = @E_ID , FirstName = @FirstName , LastName = @LastName , Address = @Address ,NIC = @NIC , MobileNo= @MobileNo , Email =  @Email , DOB = @DOB , Gender = @Gender , UserName = @UserName , Password = @Password  WHERE A_ID = @A_ID";

                      SqlCommand cmd = new SqlCommand(sql, conn);

                    //Create Parameter to add data
                      cmd.Parameters.AddWithValue("@A_ID", A_ID);
                      cmd.Parameters.AddWithValue("@AccountType",AccountType);
                      cmd.Parameters.AddWithValue("@E_ID",E_ID);
                      cmd.Parameters.AddWithValue("@FirstName",FirstName);
                      cmd.Parameters.AddWithValue("@LastName",LastName);
                      cmd.Parameters.AddWithValue("@Address",Address);
                      cmd.Parameters.AddWithValue("@NIC",NIC);
                      cmd.Parameters.AddWithValue("@MobileNo",MobileNo);
                      cmd.Parameters.AddWithValue("@Email",Email);
                      cmd.Parameters.AddWithValue("@DOB",DOB);
                      cmd.Parameters.AddWithValue("@Gender",Gender);
                      cmd.Parameters.AddWithValue("@UserName",UserName);
                      cmd.Parameters.AddWithValue("@Password",Password);


                      conn.Open();
                      int rows = cmd.ExecuteNonQuery();
                      //If the quary runs successfully then the value of rows will be greater than zero else its value will be 0
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





        //Metod Delete Data from Database
        public bool Delete(EmployeeDetails c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_Employee WHERE A_ID = @A_ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@A_ID", c.A_ID);


                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the quary runs successfully then the value of rows will be greater than zero else its value will be 0
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




        //get supplierID
        public static bool loginValidate(string username, string pw, string role, ref string name)
        {
            bool isSuccess = false;

            ///Step 1: Data Base Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            
            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_Employee";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string uRole = dr["AccountType"].ToString();
                    string uname = dr["UserName"].ToString();
                    string uPW = dr["Password"].ToString();
                    name = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();

                    if(username == uname && pw == uPW && role == uRole)
                    {
                        isSuccess = true;
                        return isSuccess;
                    } 

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


        public static bool AdminLoginValidate(string username, string pw, string role)
        {
            bool isSuccess = false;

            ///Step 1: Data Base Connection
            SqlConnection conn = new SqlConnection(myconnstrng);


            DataTable dt = new DataTable();

            try
            {

                //sql query
                string sql = "SELECT * FROM tbl_admin";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string uRole = dr["AccountType"].ToString();
                    string uname = dr["UserName"].ToString();
                    string uPW = dr["Password"].ToString();
                    

                    if (username == uname && pw == uPW && role == uRole)
                    {
                        isSuccess = true;
                    }

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















    }
}
