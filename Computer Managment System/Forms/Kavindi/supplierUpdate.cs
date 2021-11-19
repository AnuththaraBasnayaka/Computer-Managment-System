using Computer_Managment_System.Classes;
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

namespace Computer_Managment_System
{
    public partial class supplierUpdate : Form
    {
        public static int SupplierID;

        public supplierUpdate()
        {
            InitializeComponent();
        }


        supplierDBUtill c = new supplierDBUtill();

        
       
        private void supplierUpdate_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvSupplierDetails.DataSource = dt;

            dgvSupplierDetails.Columns[0].ReadOnly = true;
        }



      
        private void bunifuButtonUpdate_Click(object sender, EventArgs e)
        {
            
        }



        private void bunifuButtonDelete_Click(object sender, EventArgs e)
        {

            
        }

       

        private void dgvSupplierDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowIndex = e.RowIndex;
            c.SupplierID = Convert.ToInt32(dgvSupplierDetails.Rows[rowIndex].Cells[0].Value.ToString());


        }




        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

            // Get the value from textBox

            string keyword = TextBoxSearch.Text;
            dgvSupplierDetails.DataSource = c.Search(keyword);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            

        }

        private void bunifuButtonUpdate_Click_1(object sender, EventArgs e)
        {
            //Save data grid into a DataTable
            DataTable dt = new DataTable();




            for (int i = 0; i < dgvSupplierDetails.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }



            foreach (DataGridViewRow row in dgvSupplierDetails.Rows)
            {
                DataRow dr = dt.NewRow();



                for (int j = 0; j < dgvSupplierDetails.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }




            // Update

            bool success = c.Update(dt);


            if (success == true)
            {

                // Successfully Inserted Message
                MessageBox.Show("Data has successfully updated!");

            }
            else
            {

                // Failed Inserted Message
                MessageBox.Show("Failed to Update the Data!");

            }
        }

        private void bunifuButtonDelete_Click_1(object sender, EventArgs e)
        {
            // Get the SupplierID from the Application form

            //c.SupplierID = Convert.ToInt32(textBoxID.Text);

            bool success = c.Delete(c);

            if (success == true)
            {

                // Successfully Deleted Message
                MessageBox.Show("Supplier Successfully Deleted!");

                DataTable dt = c.Select();
                dgvSupplierDetails.DataSource = dt;

                dgvSupplierDetails.Columns[0].ReadOnly = true;

            }
            else
            {

                // Failed to delete
                MessageBox.Show("Failed to Delete Supplier!");
            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButtonReport_Click(object sender, EventArgs e)
        {

        }
    }
}
