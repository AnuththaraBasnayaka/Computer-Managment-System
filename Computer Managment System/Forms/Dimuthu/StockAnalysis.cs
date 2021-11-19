using Computer_Managment_System.Classes.Dimuthu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System.Forms.Dimuthu
{
    public partial class StockAnalysis : Form
    {
        public StockAnalysis()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            String keyWord = bunifuTextBox1.Text;
            ItemTotTbl.DataSource = StockData.GetItemData(keyWord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal colsum = 0;

            for (int r = 0; r < ItemTotTbl.Rows.Count; ++r)
            {
                colsum += Convert.ToDecimal(ItemTotTbl.Rows[r].Cells[8].Value);
            }

            totalItemCount.Text = colsum.ToString();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
