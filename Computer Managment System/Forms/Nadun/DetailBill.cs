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
    public partial class detailBill : Form
    {
        public static int invoiceId;
        public detailBill(int id)
        {
            invoiceId = id;
            InitializeComponent();
        }
        createInvoice d = new createInvoice();

        private void detailBillGRID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load data into gridview
            //detailBillGRID.DataSource = dt;
        }

        private void detailBill_Load(object sender, EventArgs e)
        {
            createInvoice.Select2(invoiceId);
            DataTable dt = createInvoice.Select2(invoiceId);
            detailBillGRID.DataSource = dt;
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

            
    }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBTN_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < detailBillGRID.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in detailBillGRID.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < detailBillGRID.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }
            bool success = createInvoice.UpdateOrderItems(dt); //(dt, invoiceID);
            if (success == true)
            {
                MessageBox.Show("Inserted successfully");
            }
            else
            {
                MessageBox.Show("Insert Failed");
            }
        }

        private void deleteBTN_Click_1(object sender, EventArgs e)
        {
            bool success = d.Remove(invoiceId);
            if (success == true)
            {
                MessageBox.Show("Deleted successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
