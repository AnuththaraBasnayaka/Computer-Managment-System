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
    public partial class Quotations : Form
    {
        public Quotations()
        {
            InitializeComponent();
        }
        Customer c = new Customer();
        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            //Orders orderPage = new Orders();
           /// this.Hide();
          //  orderPage.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            txt_username.Text = "Madhushan Liyanage";
            //add items to the Brand combo Box
            DataTable dt = QuotationDBUtil.SelectBrand();
            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_brandQ.Items.Add(dr["Brand"].ToString());
            }
        }

       /* private void Quotations_load(object sender, EventArgs e) 
        {
            //add items to the Brand combo Box
            DataTable dt = QuotationDBUtil.SelectBrand();
            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_brandQ.Items.Add(dr["Brand"].ToString());
            }
        }*/

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Quotations quotations = new Quotations();
            quotations.Show();


        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Quotation q = new Quotation();
        public static string totalPrice;
        private void btn_CreateQuotation_Click(object sender, EventArgs e)
        {

            q.BrandQ = cmbBox_brandQ.Text;
            q.CatergoryQ = cmbBox_categoryQ.Text;
            q.ItemnameQ = cmbBox_itemNameQ.Text;
            q.Total = totalPrice;
            



            //Save data grid into a DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < QItemsGrid.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in QItemsGrid.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < QItemsGrid.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }

            q.dataTable = dt;

            /*for(int rows = 0; rows<dt.Rows.Count; rows++)
            {
                string name = (string)dt.Rows[rows][1];
            }*/

          
                int qid = QuotationDBUtil.getQID();

              bool  success = QuotationDBUtil.insertQuotationItems(dt, qid);

                if (success == true)
                {
                    MessageBox.Show("Quotation has successfully Created");

                    
                    ViewQuotation viewQuotation = new ViewQuotation(qid);
                    viewQuotation.Show();

                    
            }
                else
                {
                    MessageBox.Show("Failed to insert the data");
                }









        }
        public static int total;
        public static int amount;
        
        private void btn_addItemQ_Click(object sender, EventArgs e)
        {
            int n = QItemsGrid.Rows.Add();

            string brand = cmbBox_brandQ.Text.ToString();
            string category = cmbBox_categoryQ.Text.ToString();
            string itemName = cmbBox_itemNameQ.Text.ToString();
            string serial;
            string unitPrice;



            DataTable dt = QuotationDBUtil.SelectItemDetails(brand, category, itemName);

            foreach (DataRow dr in dt.Rows)
            {
                serial = dr["SerialNumber"].ToString();
                unitPrice = dr["UnitPrice"].ToString();

                QItemsGrid.Rows[n].Cells[0].Value = serial;
                QItemsGrid.Rows[n].Cells[3].Value = unitPrice;
            }

            QItemsGrid.Rows[n].Cells[1].Value = cmbBox_itemNameQ.Text;
            QItemsGrid.Rows[n].Cells[2].Value = txtBox_qtyQ.Text;
            try
            {
                string Qty = QItemsGrid.Rows[n].Cells[2].Value.ToString();
                string UnitPrice = QItemsGrid.Rows[n].Cells[3].Value.ToString();

                int total = 0;
                int qty = Convert.ToInt32(Qty);
                int uPrice = Convert.ToInt32(UnitPrice);
                total = uPrice * qty;

                string totalPrice = Convert.ToString(total);

                QItemsGrid.Rows[n].Cells[4].Value = totalPrice;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
            }
            //calcualate total
            amount = 0;

            try
            {
                for (int rows = 0; rows < QItemsGrid.Rows.Count; rows++)
                {
                    string sQty = QItemsGrid.Rows[rows].Cells[2].Value.ToString();
                    string sUnitPrice = QItemsGrid.Rows[rows].Cells[3].Value.ToString();

                    int Tqty = Convert.ToInt32(sQty);
                    int UPrice = Convert.ToInt32(sUnitPrice);

                    amount = amount + (UPrice * Tqty);
                }

                Qtotalamount.Text = Convert.ToString(amount);
                c.TotalAmount = Convert.ToString(amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
                QItemsGrid.Rows.RemoveAt(n);
            }

            cmbBox_itemNameQ.Text = "";
            txtBox_qtyQ.Text = "";


        }

        private void cmbBox_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = cmbBox_brandQ.Text.ToString();
            DataTable dt = QuotationDBUtil.SelectCategory(brand);

            //clear Category combo Box
            cmbBox_categoryQ.Items.Clear();


            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_categoryQ.Items.Add(dr["Catogery"].ToString());

            }
        }

        private void cmbBox_categoryQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = cmbBox_brandQ.Text.ToString();
            string category = cmbBox_categoryQ.Text.ToString();

            DataTable dt = QuotationDBUtil.SelectItems(brand, category);

            //clear combobox
            cmbBox_itemNameQ.Items.Clear();

            //add items for the combobox
            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_itemNameQ.Items.Add(dr["ItemName"].ToString());

            }
        }

        private void cmbBox_itemNameQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
        
        private void bunifuButton26AddCustomer_Click(object sender, EventArgs e)
        {

            CustomerDetailQ customerDetailQ = new CustomerDetailQ(c.TotalAmount);
            customerDetailQ.Show();
        }

        private void Qtotalamount_Click(object sender, EventArgs e)
        {

        }

        private void QItemsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton26viewQ_Click(object sender, EventArgs e)
        {
            ViewQuotationList viewQuotationList = new ViewQuotationList();
            viewQuotationList.Show();
        }
    }
}
