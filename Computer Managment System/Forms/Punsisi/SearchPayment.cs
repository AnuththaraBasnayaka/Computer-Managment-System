
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_Managment_System.Classes;

namespace Computer_Managment_System
{
    public partial class SearchPayment : Form
    {
        public SearchPayment()
        {
            InitializeComponent();
        }

        paymentdata p = new paymentdata();

        private void btnSalary_Click(object sender, EventArgs e)
        {

           

        }

        private void SearchPayment_Load(object sender, EventArgs e)
        {
            //Loard Data on Data GrideView
            DataTable dt1 = p.Select();
            dgvSearch.DataSource = dt1;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            //Get the value from textbox

            string keyword = textBoxSearch.Text;
            dgvSearch.DataSource = p.Search(keyword);
        }

        private void btnSalary_Click_1(object sender, EventArgs e)
        {
            // Salary objSearch = new Salary();
            this.Hide();
            //  objSearch.Show();
        }
    }
}
