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

namespace Computer_Managment_System.Forms.Shashika
{
    public partial class ordersMonthlyRep : Form
    {
        public ordersMonthlyRep()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            date dt = new date();
            DataTable dt_report = new DataTable();

            string year = txtbox_year.Text;
            string month = cmbBox_month.Text;


            if (String.IsNullOrEmpty(txtbox_year.Text) || String.IsNullOrEmpty(cmbBox_month.Text))
            {
                MessageBox.Show("Please Enter the Values");
            } else
            {
                //Get dates
                dt = date.createDate(year, month);

                dt_report = orderDBUtill.ordersMonthlyReport(dt.date1, dt.date2);




                MonthlyOrdersPrint.Clear();





                MonthlyOrdersPrint.AddImage(imgLogo.Image, "width= 150, style='float:right'");

                MonthlyOrdersPrint.AddHorizontalRule();

                MonthlyOrdersPrint.AddString("<h1>Monthly Report - " + month + " " + year + "</h1>");

                MonthlyOrdersPrint.AddHorizontalRule();


                
                MonthlyOrdersPrint.AddLineBreak();
                MonthlyOrdersPrint.AddLineBreak();
                MonthlyOrdersPrint.AddLineBreak();

                MonthlyOrdersPrint.AddDataTable(dt_report);

                MonthlyOrdersPrint.ShowPrintPreviewDialog();
            }

        }
    }
}
