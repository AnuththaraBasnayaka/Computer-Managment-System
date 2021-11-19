using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_Managment_System.Classes;

namespace Computer_Managment_System
{
    public partial class Login : Form
    {

        public static string name;

        public Login()
        {
            InitializeComponent();

            
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_bx_username.Text;
            string password = txt_bx_password.Text;
            string role = cmBox_Role.Text;

            //login validate
            bool isSuccess = EmployeeDetails.loginValidate(username, password, role, ref name);

            bool isAdmin = EmployeeDetails.AdminLoginValidate(username, password, role);

            
            if (role == "Admin" && isAdmin == true)
            {
                if(isAdmin == true)
                {
                    AdminDashboard admin = new AdminDashboard("Admin");
                    this.Hide();
                    admin.Show();
                } 
            } else if(role == "Manager" && isSuccess == true)
            {
                Dashboard manager = new Dashboard(name);
                this.Hide();
                manager.Show();
            } else if(role == "SalesPerson" && isSuccess == true)
            {
                SellerDashboard seller = new SellerDashboard(name);
                this.Hide();
                seller.Show();
            } else
            {
                MessageBox.Show("Login Failed");
            }
  

        }
    }
}
