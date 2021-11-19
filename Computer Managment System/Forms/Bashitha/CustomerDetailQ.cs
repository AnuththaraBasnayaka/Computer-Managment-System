using Computer_Managment_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System
{
    public partial class CustomerDetailQ : Form
    {
        Customer c = new Customer();
        public CustomerDetailQ(string amount)
        {
            c.TotalAmount = amount;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }
        

       
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }





        // Email Validation

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }




        static Regex validate_emailaddress = email_validation();





        // Insert Customer Details

        private void btn_addItem_Click_1(object sender, EventArgs e)
        {

            if (validate_emailaddress.IsMatch(txtBox_CustomerEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBox_CustomerEmail.Focus();
                return;
            }else
            {
                c.Date = txt_Qdate.Text;
                c.Name = txtBox_CustomerName.Text;
                c.No = txtBox_TeleNo.Text;
                c.Email = txtBox_CustomerEmail.Text;
                c.Address = txtBox_Address.Text;


                bool success = QuotationDBUtil.insertCustomer(c);
                if (success == true)
                {
                    MessageBox.Show("success");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("unsuccessful");
                }
            }
            
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_TeleNo_TextChanged(object sender, EventArgs e)
        {
            string no = txtBox_TeleNo.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Match match = regex.Match(no);



            if (match.Success)
            {



                lbl_error.Text = "";
            }
            else
            {
                lbl_error.ForeColor = Color.Red;
                lbl_error.Text = "Incorrect";



            }
        }
    }

    }
