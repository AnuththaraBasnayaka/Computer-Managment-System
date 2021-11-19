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
    public partial class order_CreateOrder : Form
    {
        public order_CreateOrder()
        {
            InitializeComponent();
        }


        //Page Load
        private void order_CreateOrder_Load(object sender, EventArgs e)
        {
            
            //add items to the Brand combo Box
            DataTable dt = orderDBUtill.SelectBrand();
            foreach(DataRow dr in dt.Rows)
            {
                cmbBox_brand.Items.Add(dr["brandName"].ToString());         
            }

            //add items to category combobox
            DataTable dt2 = orderDBUtill.SelectCategory();
            foreach (DataRow dr in dt2.Rows)
            {
                cmbBox_category.Items.Add(dr["Catogery"].ToString());
            }

        }



        //Select brand
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = cmbBox_brand.Text.ToString();
            DataTable dt = orderDBUtill.SelectSuppliers(brand);

            //clear Supplier combo Box
            cmbBox_Supplier.Items.Clear();


            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_Supplier.Items.Add(dr["SupplierName"].ToString());

            }

        }



        private void cmbBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = cmbBox_brand.Text.ToString();
            string cat = cmbBox_category.Text.ToString();

            DataTable dt = orderDBUtill.SelectItems(brand, cat);

            //clear combobox
            cmbBox_itemName.Items.Clear();

            //add items for the combobox
            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_itemName.Items.Add(dr["ItemName"].ToString());

            }

        }

        public static int tot;
        
        private void btn_addItem_Click(object sender, EventArgs e)
        {
            int n = orderItemsGrid.Rows.Add();

            string brand = cmbBox_brand.Text.ToString();
            string cat = cmbBox_category.Text.ToString();
            string iName = cmbBox_itemName.Text.ToString();
            string serial;
            string unitPrice;

            
            DataTable dt = orderDBUtill.SelectRows(brand, cat, iName);



            //validate data
            if (String.IsNullOrEmpty(cmbBox_brand.Text) || String.IsNullOrEmpty(cmbBox_Supplier.Text) || String.IsNullOrEmpty(cmbBox_category.Text) || String.IsNullOrEmpty(cmbBox_itemName.Text) || String.IsNullOrEmpty(txtBox_qty.Text))
            {
                MessageBox.Show("Please Enter the Values");
                orderItemsGrid.Rows.RemoveAt(n);
            } else
            {

                int distance;
                if (int.TryParse(txtBox_qty.Text, out distance))
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        serial = dr["SerialNumber"].ToString();
                        unitPrice = dr["UnitPrice"].ToString();

                        orderItemsGrid.Rows[n].Cells[0].Value = serial;
                        orderItemsGrid.Rows[n].Cells[3].Value = unitPrice;
                    }

                    orderItemsGrid.Rows[n].Cells[1].Value = cmbBox_itemName.Text;
                    orderItemsGrid.Rows[n].Cells[2].Value = txtBox_qty.Text;

                    //calcualate total
                    tot = 0;

                    try
                    {
                        for (int rows = 0; rows < orderItemsGrid.Rows.Count; rows++)
                        {
                            try
                            {
                                string sQty = orderItemsGrid.Rows[rows].Cells[2].Value.ToString();
                                string sUnitPrice = orderItemsGrid.Rows[rows].Cells[3].Value.ToString();

                                int qty = Convert.ToInt32(sQty);
                                int uPrice = Convert.ToInt32(sUnitPrice);

                                tot = tot + (uPrice * qty);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Please enter the value again");
                                orderItemsGrid.Rows.RemoveAt(n);
                            }

                        }

                        lbl_tot.Text = Convert.ToString(tot);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter the value again");
                        orderItemsGrid.Rows.RemoveAt(n);
                    }

                    cmbBox_itemName.Text = "";
                    txtBox_qty.Text = "";
                } else
                {
                    MessageBox.Show("Please Enter Valid values");
                    cmbBox_itemName.Text = "";
                    txtBox_qty.Text = "";
                }


            }          

        }


        Order o = new Order();

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            o.date = txt_date.Text;
            o.brand = cmbBox_brand.Text;
            o.name = cmbBox_Supplier.Text;
            o.sid = orderDBUtill.getSid(o.name, o.brand);
            o.tot = tot;
            o.status = "Pending";



            //Save data grid into a DataTable
            DataTable dt = new DataTable();
            for(int i = 0; i<orderItemsGrid.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach(DataGridViewRow row in orderItemsGrid.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < orderItemsGrid.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }


            o.dataTable = dt;

            


            /*

            for(int rows = 0; rows<dt.Rows.Count; rows++)
            {
                string name = (string)dt.Rows[rows][1];
                
            }

            */

            bool success = orderDBUtill.insert(o);



            if (success == true)
            {
                int orderID = orderDBUtill.getOrderID();

                success = orderDBUtill.insertOrderItems(dt, orderID );

                if(success == true)
                {
                    MessageBox.Show("Order has successfully Created");

                    this.Close();
                } else
                {
                    MessageBox.Show("Failed to insert the data");
                }


            }
            else
            {
                MessageBox.Show("Failed to insert the data");
            }


            

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
