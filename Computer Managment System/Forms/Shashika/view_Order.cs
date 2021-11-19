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
    public partial class view_Order : Form
    {

        public static int oid;
        Order o = new Order();
        supplier s = new supplier();


        public view_Order(int id, string sid)
        {
            o.orderID = id;
            s.supplierID = sid;
            InitializeComponent();
        }




        //View Order Page Load
        private void view_Order_Load(object sender, EventArgs e)
        {
            DataTable orderDT = new DataTable();
            DataTable itemDT = new DataTable();

            //get supplier details
            orderDBUtill.getSupplier(ref s);

            orderDBUtill.SelectOrder(ref orderDT, ref itemDT, o.orderID);

            foreach(DataRow dr in orderDT.Rows)
            {
                o.name = dr["Name"].ToString();
                o.date = dr["Date"].ToString();
                o.brand = dr["Brand"].ToString();
                o.status = dr["Status"].ToString();
                o.tot = Convert.ToInt32(dr["Amount"].ToString());
               
            }
            
            lbl_name.Text = o.name;
            lbl_OrderID.Text = o.orderID.ToString();
            lbl_Date.Text = o.date;
            lbl_Brand.Text = o.brand;
            lbl_Status.Text = o.status;


            lbl_totAmount.Text = o.tot.ToString();
            lbl_Address.Text = s.address.ToString();
            lbl_Email.Text = s.email.ToString();
            lbl_Phone.Text = s.no.ToString();


            orderItemGrid.DataSource = itemDT;
            orderItemGrid.Columns[0].ReadOnly = true;
            orderItemGrid.Columns[1].ReadOnly = true;






        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OrderUpdate_Click(object sender, EventArgs e)
        {
            //Save data grid into a DataTable
            DataTable dt = new DataTable();


            for (int i = 0; i < orderItemGrid.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in orderItemGrid.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < orderItemGrid.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }

            o.dataTable = dt;

            


            
            //calcualate total
            int totAmount = 0;

            try
            {
                for (int rows = 0; rows < orderItemGrid.Rows.Count; rows++)
                {
                    string sQty = orderItemGrid.Rows[rows].Cells[4].Value.ToString();
                    string sUnitPrice = orderItemGrid.Rows[rows].Cells[5].Value.ToString();

                    int qty = Convert.ToInt32(sQty);
                    int uPrice = Convert.ToInt32(sUnitPrice);

                    totAmount = totAmount + (uPrice * qty);
                }

                o.tot = totAmount;
                lbl_totAmount.Text = Convert.ToString(totAmount);



                //update 
                bool success = orderDBUtill.UpdateOrderItems(o);
                bool success2 = orderDBUtill.updateTot(o);



                if (success == true && success2 == true)
                {
                    MessageBox.Show("Data has successfully updated");

                }
                else
                {
                    MessageBox.Show("Failed to insert the data");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
                
            }


            




        }

        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {
            bool success = orderDBUtill.Delete(o);


            if (success == true)
            {
                MessageBox.Show("Data has successfully deleted");
                this.Close();

            }
            else
            {
                MessageBox.Show("Failed to delete the data");
            }
        }
    }
}
