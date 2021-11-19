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
    public partial class StockSearch : Form
    {
        public StockSearch()
        {
            InitializeComponent();
        }

        StockData s = new StockData();

        //method to take all the data from database to the grid
        void BindData()
        {
            DataTable dt = s.Selecttbl();
            STStableStock.DataSource = dt;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        //search item details using the serial number and catogery
        private void STSdetailsBttn_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Stocks stock = new Stocks();
            this.Hide();
            stock.Show();
        }

        private void BtnLoadItemtbl_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void STSdetailstxt_TextChanged(object sender, EventArgs e)
        {
            String keyWord = STSdetailstxt.Text;
            STStableStock.DataSource = StockData.SearchItem(keyWord);
        }

        private void STSOrdertxt_TextChanged(object sender, EventArgs e)
        {
            String keyWord = STSOrdertxt.Text;
            STStableOrder.DataSource = StockData.SearchOrderItemDet(keyWord);
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
