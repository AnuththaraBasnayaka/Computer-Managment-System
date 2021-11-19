using Computer_Managment_System.Classes.Dimuthu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Computer_Managment_System
{
    public partial class StockAdd : Form
    {
        public StockAdd()
        {
            InitializeComponent();
        }


        StockData s = new StockData();

        public void Clear()
        {
            STsertxt.Text = "";
            STnametxt.Text = "";
            STcatcombo1.Text = "";
            STbrandtxt.Text = "";
            STwtxt.Text = "";
            STdettxt.Text = "";
            STselltxt.Text = "";
            STunittxt.Text = "";
            STQtxt.Text = "";
        }

        //get data into the grid view
        void BindData()
        {
            DataTable dt = s.Selecttbl();
            STtable1.DataSource = dt;
        }
       

        //Add data to the database
        private void STaddBttn1_Click(object sender, EventArgs e)
        {
            try
            {
                //get the values from the input fields
                s.SerialNumber = STsertxt.Text;
                s.ItemName = STnametxt.Text;
                s.Category = STcatcombo1.Text;
                s.Brand = STbrandtxt.Text;
                s.Warranty = Convert.ToInt32(STwtxt.Text);
                s.ItemDetails = STdettxt.Text;
                s.SellingPrice = float.Parse(STselltxt.Text);
                s.UnitPrice = float.Parse(STunittxt.Text);
                s.ItemQuantity = Convert.ToInt32(STQtxt.Text);

                //Use the method in stockdata class for inserting data

                bool success = s.InsertItem(s);
                if (success == true)
                {
                    //If the data insert successfully
                    MessageBox.Show("Item details successfully added");

                    //call clear method

                }
                else
                {
                    //If the data adding is failed
                    MessageBox.Show("Item data adding unsuccessfull");
                }

                //load data in to the gridview
                BindData();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please enter the values");

            }
        }


        //load data in the gridview when the form open
        private void StockAdd_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void STeditBttn1_Click(object sender, EventArgs e)
        {
            stockEdits editstk = new stockEdits();
            editstk.Show();
        }

        //restore the grid
        private void STresBttn1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Stocks stock = new Stocks();
            this.Hide();
            stock.Show();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
