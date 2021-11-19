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

namespace Computer_Managment_System.Forms.Anuththara
{
    public partial class ServiceRepair_Report : Form
    {
        public ServiceRepair_Report()
        {
            InitializeComponent();
        }

        servicestatusClass s = new servicestatusClass();

        //button for close report page 
        private void btn_printClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //button for Generate Report 
        private void btn_generate_Click(object sender, EventArgs e)
        {
            DataTable ServiceTbl = new DataTable();

            servicestatusClass.SelectServices(ref ServiceTbl);

            serviceReport.Clear();

            //serviceReport.AddImage(newTech_logo.Image, "width= 200");
            serviceReport.AddString("<h1><center> Customer Details Recipt </center></h1>");
            serviceReport.AddString("<h2><center>New Tech Computers Pvt(ltd)</center></h2>");
            serviceReport.AddString("<h3><center>New Tech Computers Pvt(ltd),Galle</center></h3>");
            serviceReport.AddString("<h3><center>tel : 077xxxxxxxxx/041xxxxxxxxx</center></h3>");

            serviceReport.AddString("<br>");
            serviceReport.AddString("<h1><center><hr></center></h1>");
            serviceReport.AddString("<br>");

            serviceReport.AddString("<br>");
            serviceReport.AddString("<h3 style= text - align:left; >" + " Date of generation  :" + dp_generatorDate.Text + "</h3>");

            serviceReport.AddDataTable(ServiceTbl);

            serviceReport.AddString("<br>");
            serviceReport.AddString("<br>");
            serviceReport.AddString("<h4 style= text - align:right; >" + "Report Generator Name      :" + txt_generatorName.Text + "</h4>");

            serviceReport.ShowPrintPreviewDialog();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
