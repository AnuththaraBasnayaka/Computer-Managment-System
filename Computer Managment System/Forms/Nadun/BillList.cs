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
    public partial class BillList : Form
    {
        //public static int invoiceId;
       
        public BillList()
        {
            //invoiceId = id;
            InitializeComponent();
        }
        createInvoice d = new createInvoice();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load data into gridview
            DataTable dt = d.Select();
            billLineUpGRID.DataSource = dt;
        }

        private void BillList_Load(object sender, EventArgs e)
        {
            DataTable dt = d.Select();
            billLineUpGRID.DataSource = dt;
        }

        private void billLineUpGRID_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            
        }

        private void billLineUpGRID_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the id from Grid 
            //Identify the clicked row
            int rowindex = e.RowIndex;
            string Sinid = billLineUpGRID.Rows[rowindex].Cells[0].Value.ToString();
            int id = Convert.ToInt32(Sinid);
            detailBill db = new detailBill(id);
            db.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
           /* //Refresh item table
            DataTable dt = createInvoice.Select2(invoiceId);
            billLineUpGRID.DataSource = dt;
           */
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Search textbox
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = createInvoice.Search(textBoxSearch.Text);
            billLineUpGRID.DataSource = dt;

        }

        private void lbl_Refresh_Click(object sender, EventArgs e)
        {
            //Load data into gridview
            DataTable dt = d.Select();
            billLineUpGRID.DataSource = dt;
        }

        private void btn_reportInvoice_Click(object sender, EventArgs e)
        {

            string date = pickDate.Text;


            string tot = createInvoice.calInvoiceTot(date);


            //Date validation
            if (DateTime.Today < pickDate.Value)
            {
                MessageBox.Show("You Select Data is Invalid", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pickDate.Value = DateTime.Today;
            }


            //items to a data table
            createInvoice.reportCalc(date);

            DataTable dt2 = createInvoice.reportCalc(date);
            //dt2 = createInvoice.reportCalc(date);

            printReport.Clear();

            printReport.AddString("<h1>Daily Sales Summery - " + date + "</h1>");

            //data table item print
            printReport.AddDataTable(dt2);

            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();


            printReport.AddString("<h2>Total Daily Sales : Rs."+tot+".00"+"</h2>");



            //printReport.AddString(" NewTech(PVT)Ltd. | Email- support@newtech.lk | Visit Us on - www.newtech.lk | Support - www.newtech.lk/support | Hotline - 0912247323 ");

            printReport.ShowPrintPreviewDialog();
        }
    }
}
