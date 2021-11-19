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
    public partial class ServiceRepair_Print : Form
    {
        public ServiceRepair_Print()
        {
            InitializeComponent();
        }

        private void btn_printClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //print the recipt details
        private void btn_printRecipt_Click(object sender, EventArgs e)
        {
            repair_ReciptReport.Clear();

            repair_ReciptReport.AddImage(newTech_logo.Image,"width= 200");
            repair_ReciptReport.AddString("<h1><center> Customer Details Recipt </center></h1>");
            repair_ReciptReport.AddString("<h2><center>New Tech Computers Pvt(ltd)</center></h2>");
            repair_ReciptReport.AddString("<h3><center>New Tech Computers Pvt(ltd),Galle</center></h3>");
            repair_ReciptReport.AddString("<h3><center>tel : 077xxxxxxxxx/041xxxxxxxxx</center></h3>");
            repair_ReciptReport.AddString("<br>");
            repair_ReciptReport.AddString("<h3 >----Your Service is Now Confirmed----</h3>");
            repair_ReciptReport.AddString("<h3 style= text - align:left; >" + " Date of Issue  :" + issuedatePicker.Text + "</h3>");
            repair_ReciptReport.AddString("<br>"); 
            repair_ReciptReport.AddString("<h1><center><hr></center></h1>");
            repair_ReciptReport.AddString("<br>");
           

            repair_ReciptReport.AddString("<h3 style= text - align:left; >" + "Job ID             :" + txt_JobIDPrint.Text + "</h3>");
            repair_ReciptReport.AddString("<h3 style= text - align:left; >" + "Customer Name      :" + txt_PrintClientName.Text + "</h3>");
            repair_ReciptReport.AddString("<h3 style= text - align:left; >" + "Note Details       :" + txt_PrintNote.Text + "</h3>");
            repair_ReciptReport.AddString("<br>");
            repair_ReciptReport.AddString("<h1 style= text - align:left; >" + "Payments Amount Rs :" + txt_paymentDetails.Text + "</h1>");


            repair_ReciptReport.AddString("<br>");
            repair_ReciptReport.AddString("<br>");
            repair_ReciptReport.AddString("<h1><center><hr></center></h1>");
            repair_ReciptReport.AddString("<h1><center> Thank You ...!</center></h1>");
            repair_ReciptReport.AddString("<h1><center> Hava a nice day, Come Again..! </center></h1>");

           

            //repair_ReciptReport.AddString("<h3>" + PrintComment.Text + "</h3>");

            repair_ReciptReport.ShowPrintPreviewDialog();
        }

        public void Clear()
        {
            txt_JobIDPrint.Text = "";
            txt_PrintClientName.Text = "";
            txt_PrintNote.Text = "";
            issuedatePicker.Text = "";
            txt_paymentDetails.Text = "";
        }


        private void btn_clearDetails_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
