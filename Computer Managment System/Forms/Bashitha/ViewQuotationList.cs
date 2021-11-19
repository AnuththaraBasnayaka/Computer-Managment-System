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
    public partial class ViewQuotationList : Form
    {
        public ViewQuotationList()
        {
            InitializeComponent();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            //Orders orderPage = new Orders();
           /// this.Hide();
          //  orderPage.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        { 

            //load data to the data grid
            DataTable dt = QuotationDBUtil.SelectQuotationList();
            QuotationListGrid.DataSource = dt;
            
       

        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            
        }






        
        private void orderListGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void testGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }




        //Grid Cell click event
        private void orderListGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           



        }



        //create order button click event
        private void btn_createOrder_Click(object sender, EventArgs e)
        {
            order_CreateOrder createOrder = new order_CreateOrder();
            createOrder.Show();
        }

        private void testB_Click(object sender, EventArgs e)
        {
          //  view_Order viewOD = new view_Order("S002");
         //   viewOD.Show();
        }

        private void QuotationListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void lbl_Order_Click(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuotationListGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int oid = Convert.ToInt32(QuotationListGrid.Rows[rowIndex].Cells[0].Value.ToString());
            ViewQuotation viewquotation = new ViewQuotation(oid);
            viewquotation.Show();
        }

        private void lbl_Refresh_Click(object sender, EventArgs e)
        {
            //load data to the data grid
            DataTable dt = QuotationDBUtil.SelectQuotationList();
            QuotationListGrid.DataSource = dt;
        }

        private void btn_printReportQ_Click(object sender, EventArgs e)
        {
            DataTable reportDT = new DataTable();

            QuotationDBUtil.SelectReport(ref reportDT);


            qReports.Clear();


            qReports.AddImage(imgLogo.Image, "width= 150, style='float:right'");
            qReports.AddHorizontalRule();

            qReports.AddString("<h2>Most Requested Items</h2><br>");

            qReports.AddHorizontalRule();

            qReports.AddLineBreak();
            qReports.AddLineBreak();

            qReports.AddDataTable(reportDT);
            qReports.ShowPrintPreviewDialog();
        }

        private void txtBox_SearchCustomer_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = QuotationDBUtil.SearchCustomer(txtBox_SearchCustomer.Text);
            QuotationListGrid.DataSource = dt;
        }
    }
}
