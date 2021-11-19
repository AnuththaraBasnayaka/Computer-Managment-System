using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Computer_Managment_System.Classes;
using Computer_Managment_System.Forms.Dimuthu;
using System.Data.SqlClient;

namespace Computer_Managment_System
{
    public partial class AdminDashboard : Form
    {

        public static string UserName;

        public AdminDashboard(string uname)
        {
            UserName = uname;
            InitializeComponent();
        }


        /*-----------------------------------------------------------------Page Navigation---------------------------------------------------------*/
        private void Dashboard_Load(object sender, EventArgs e)
        {
            txt_username.Text = UserName;


           

        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            AdminDashboardPages.SetPage("UserAccounts");
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            AdminDashboardPages.SetPage("Home");
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            AdminDashboardPages.SetPage("Stock");
        }










        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
        /*-------------------------------------------------------------- P.G.T Dilshan - IT20117764 -----------------------------------------------------------*/
        EmployeeDetails c = new EmployeeDetails();


        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex validate_emailaddress = email_validation();



        //Method to clear Fields
        public void Clear()
        {

            cmbAccountType.Text = "";
            txtBoxEid.Text = "";
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxNic.Text = "";
            txtBoxMobileNo.Text = "";
            txtBoxEmail.Text = "";
            txtBoxDob.Text = "";
            cmbGender.Text = "";
            txtBoxUserName.Text = "";
            txtBoxPassword.Text = "";


        }


       

        private void btn_View_Click(object sender, EventArgs e)
        {
            ViewDetails v = new ViewDetails();
            v.Owner = this;
            v.Show();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            //Validate the completion of the field
            if (string.IsNullOrEmpty(cmbAccountType.Text) || string.IsNullOrEmpty(txtBoxEid.Text) || string.IsNullOrEmpty(txtBoxFirstName.Text) || string.IsNullOrEmpty(txtBoxLastName.Text) || string.IsNullOrEmpty(txtBoxAddress.Text) || string.IsNullOrEmpty(txtBoxNic.Text) || string.IsNullOrEmpty(txtBoxMobileNo.Text) || string.IsNullOrEmpty(txtBoxEmail.Text) || string.IsNullOrEmpty(txtBoxDob.Text) || string.IsNullOrEmpty(cmbGender.Text) || string.IsNullOrEmpty(txtBoxUserName.Text) || string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                MessageBox.Show("Please enter detais Again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                //Validate Email 
                if (validate_emailaddress.IsMatch(txtBoxEmail.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBoxEmail.Focus();
                    return;

                }
                else
                {
                    //Validate Date
                    if (DateTime.Today < txtBoxDob.Value)
                    {
                        MessageBox.Show("You Select Data is Invalid", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtBoxDob.Value = DateTime.Today;
                    }
                    else
                    {
                        // Get the value from the input fields
                        c.AccountType = cmbAccountType.Text;
                        c.E_ID = txtBoxEid.Text;
                        c.FirstName = txtBoxFirstName.Text;
                        c.LastName = txtBoxLastName.Text;
                        c.Address = txtBoxAddress.Text;
                        c.NIC = txtBoxNic.Text;
                        c.MobileNo = txtBoxMobileNo.Text;
                        c.Email = txtBoxEmail.Text;
                        c.DOB = txtBoxDob.Text;
                        c.Gender = cmbGender.Text;
                        c.UserName = txtBoxUserName.Text;
                        c.Password = txtBoxPassword.Text;

                        //Inserting Data into Databade using the method we created in previos episode
                        bool success = c.Insert(c);
                        if (success == true)
                        {
                            MessageBox.Show("New Contact Successfully Inserted");

                            //Call the Clear Method Here
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Filed to add new contact. Try Again.");
                        }
                    }
                }
            }
        }



        //Button - Sign Out
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();

        }


        private void chboxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxShow.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
        }











        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
       /*-------------------------------------------------------------- Dimuthu - ITXXXXXXX -----------------------------------------------------------*/



        private void STbtnAdd_Click(object sender, EventArgs e)
        {
            StockAdd addPage = new StockAdd();
            //this.Hide();
            addPage.Show();
        }

        private void STBtnAnalyse_Click(object sender, EventArgs e)
        {
            StockAnalysis stkAnalyse = new StockAnalysis();
            stkAnalyse.Show();
        }

        private void STBtnSearch_Click(object sender, EventArgs e)
        {
            StockSearch searchdat = new StockSearch();
          //  this.Hide();
            searchdat.Show();
        }

        private void STBtnPrint_Click(object sender, EventArgs e)
        {
            StockPrintcs stkprint = new StockPrintcs();
            stkprint.Show();
        }

        private void txtBoxMobileNo_TextChanged(object sender, EventArgs e)
        {
            string no = txtBoxMobileNo.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Match match = regex.Match(no);



            if (match.Success)
            {



                lbl_Error.Text = "";
            }
            else
            {
                lbl_Error.ForeColor = Color.Red;
                lbl_Error.Text = "Incorrect";



            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
