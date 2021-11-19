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
    public partial class stockEdits : Form
    {
        public stockEdits()
        {
            InitializeComponent();
        }

        StockData s = new StockData();

        public void Clear()
        {
            STEdserbox.Text = "";
            STEdnamebox.Text = "";
            STEdcatcomb.Text = "";
            STEdbrandbox.Text = "";
            STEdwarbox.Text = "";
            STEdidetbox.Text = "";
            STEdsellbox.Text = "";
            STEdunitbox.Text = "";
            STEdiquabox.Text = "";
        }

        //get data into the grid view
        void BindData()
        {
            DataTable dt = s.Selecttbl();
            STEdtable2.DataSource = dt;
        }

        private void stockEdits_Load(object sender, EventArgs e)
        {
            BindData();
        }

        //Update the item data
        private void STEdupBttn1_Click(object sender, EventArgs e)
        {
            try
            {
                //get the values from the input fields
                s.SerialNumber = STEdserbox.Text;
                s.ItemName = STEdnamebox.Text;
                s.Category = STEdcatcomb.Text;
                s.Brand = STEdbrandbox.Text;
                s.Warranty = Convert.ToInt32(STEdwarbox.Text);
                s.ItemDetails = STEdidetbox.Text;
                s.SellingPrice = float.Parse(STEdsellbox.Text);
                s.UnitPrice = float.Parse(STEdunitbox.Text);
                s.ItemQuantity = Convert.ToInt32(STEdiquabox.Text);

                //Use the method in stockdata class for inserting data

                bool success = s.UpdateItems(s);
                if (success == true)
                {
                    //If the data insert successfully
                    MessageBox.Show("Item details successfully Updated");

                    //call clear method

                }
                else
                {
                    //If the data adding is failed
                    MessageBox.Show("Item data updating unsuccessfull");
                }

                //load data in to the gridview
                BindData();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please enter the values");

            }
        }

        //get the grid data to the form view
        private void STEdtable2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (STEdtable2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                STEdtable2.CurrentRow.Selected = true;

                STEdserbox.Text = STEdtable2.Rows[e.RowIndex].Cells[0].Value.ToString();
                STEdnamebox.Text = STEdtable2.Rows[e.RowIndex].Cells[1].Value.ToString();
                STEdcatcomb.Text = STEdtable2.Rows[e.RowIndex].Cells[2].Value.ToString();
                STEdbrandbox.Text = STEdtable2.Rows[e.RowIndex].Cells[3].Value.ToString();
                STEdwarbox.Text = STEdtable2.Rows[e.RowIndex].Cells[4].Value.ToString();
                STEdidetbox.Text = STEdtable2.Rows[e.RowIndex].Cells[5].Value.ToString();
                STEdsellbox.Text = STEdtable2.Rows[e.RowIndex].Cells[6].Value.ToString();
                STEdunitbox.Text = STEdtable2.Rows[e.RowIndex].Cells[7].Value.ToString();
                STEdiquabox.Text = STEdtable2.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        //delete the item data
        private void STEddelBttn1_Click(object sender, EventArgs e)
        {

            //Get the Serial number from the application
            s.SerialNumber = STEdserbox.Text;

            bool success = s.DeleteItem(s);

            if (success == true)
            {
                MessageBox.Show("Item Successfully deleted");

                DataTable dt = s.Selecttbl();
                STEdtable2.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete the item");
            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
