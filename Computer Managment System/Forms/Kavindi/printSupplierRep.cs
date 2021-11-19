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

namespace Computer_Managment_System.Forms.Kavindi
{
    public partial class printSupplierRep : Form
    {
        public printSupplierRep()
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
            DataTable sup_dt = new DataTable();

            string year = txtbox_year.Text;
            string month = cmbBox_month.Text;

            dt = date.createDate(year, month);

            sup_dt = supplierDBUtill.supplierMonthlyRep(dt.date1, dt.date2);




            printReport.Clear();


            printReport.AddImage(imgLogo.Image, "width= 150, style='float:right'");
            printReport.AddHorizontalRule();

            printReport.AddString("<h1>Monthly Report - "+month+" "+year+"</h1>");

            printReport.AddHorizontalRule();
            printReport.AddLineBreak();
            printReport.AddLineBreak();
            printReport.AddLineBreak();

            printReport.AddDataTable(sup_dt);

            printReport.ShowPrintPreviewDialog();







        }
    }
}
