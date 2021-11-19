using Computer_Managment_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Computer_Managment_System
{
    public partial class ViewDetails : Form
    {
        public ViewDetails()
        {
            InitializeComponent();
        }

        EmployeeDetails c = new EmployeeDetails();

        // public static int A_ID;
        

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            //Load data on Data GrideView
            DataTable dt = c.Select();
            dgvView.DataSource = dt;

            this.dgvView.Columns["A_ID"].Visible = false;

            dgvView.Columns[0].ReadOnly = true;

        }

        

       

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Save data grid into a DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < dgvView.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in dgvView.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < dgvView.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }

            c.dataTable = dt;

            //update 
            bool success = EmployeeDetails.Update(c);



            if (success == true)
            {
                MessageBox.Show("Data has successfully updated");

            }
            else
            {
                MessageBox.Show("Failed to insert the data");
            }
        }



        

        
        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            c.A_ID = Convert.ToInt32(dgvView.Rows[rowIndex].Cells[0].Value.ToString());
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
      

            bool success = c.Delete(c);

            if (success == true)
            {
                //Updateed Delete
                MessageBox.Show("Contact has been Successfullu Delete!");

                //Refresh Data Gridview
                //Load Data on data GRidview
                DataTable dt = c.Select();
                dgvView.DataSource = dt;

               
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Contact. Try Again");
            }
        }






        

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
