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
    public partial class StockPrintcs : Form
    {
        public StockPrintcs()
        {
            InitializeComponent();
        }

        StockData s = new StockData();

        //Getting the database connection
        SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-IVQS33F\SQLEXPRESS;Initial Catalog=NewTechDB;Integrated Security=True");


            private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                //e.Graphics.DrawString("NEW TECH COMPUTERS", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(250, 80));
                //e.Graphics.DrawString("Monthly Item Availability Report", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(255, 120));
                //e.Graphics.DrawString("New Tech Computers, Beach road, Galle", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(250, 147));
                //e.Graphics.DrawString("Contact Detail: 077......./070........", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(270, 170));
            }

            private void StockPrintcs_Load(object sender, EventArgs e)
            {
                //BindData();
            }

            private void bunifuButton1_Click(object sender, EventArgs e)
            {

            DataTable AvailabilityTbl = new DataTable();

            StockData.SelectAvailability(ref AvailabilityTbl, s.ItemQuantity);

            PrintItemAvailability.Clear();

            //add the system logo
            PrintItemAvailability.AddImage(system_Logo.Image, "width= 350");
            //PrintItemAvailability.AddString("<h1><div style = 'float:center;margin-top;'><b>New Tech Computers Pvt(ltd),</b></div></h1>");

            PrintItemAvailability.AddLineBreak();
            //add the report name
            PrintItemAvailability.AddString("<h1><div style = 'float:right;margin-top;'><b>Item Availability Report</b></div></h1>");
            //PrintItemAvailability.AddString("<h1>Item Availability Report</h1>");
            //add a horizontal
            PrintItemAvailability.AddHorizontalRule();
            //add the report generation date and comment on report
            PrintItemAvailability.AddLineBreak();
            PrintItemAvailability.AddLineBreak();
            PrintItemAvailability.AddString("<h3>" +printdate.Text+ "</h3>");
            //PrintItemAvailability.AddString("<h3>" + PrintComment.Text + "</h3>");

            //add line break
            PrintItemAvailability.AddLineBreak();
            PrintItemAvailability.AddLineBreak();
            PrintItemAvailability.AddLineBreak();

            PrintItemAvailability.AddDataTable(AvailabilityTbl);

            //add a footer horizontalbar
            PrintItemAvailability.AddHorizontalRule();


            PrintItemAvailability.AddString("<h3><center> New Tech Computers, Sri Lanka </center></h3>");


            PrintItemAvailability.ShowPrintPreviewDialog();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
