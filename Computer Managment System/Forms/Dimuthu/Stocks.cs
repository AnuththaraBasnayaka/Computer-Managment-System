using Computer_Managment_System.Forms.Dimuthu;
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
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            //Orders orderPage = new Orders();
            //this.Hide();
            //orderPage.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

       private void STbtnAdd_Click(object sender, EventArgs e)
        {
            StockAdd addPage = new StockAdd();
            this.Hide();
            addPage.Show();
        }

        private void STBtnSearch_Click(object sender, EventArgs e)
        {
            StockSearch searchdat = new StockSearch();
            this.Hide();
            searchdat.Show();
        }


        private void STBtnPrint_Click(object sender, EventArgs e)
        {
            StockPrintcs stkprint = new StockPrintcs();
            stkprint.Show();
        }

        private void analysisStock_Click(object sender, EventArgs e)
        {
            StockAnalysis stkAnalyse = new StockAnalysis();
            stkAnalyse.Show();
        }
    }
}
