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
    public partial class Orders : Form
    {

        Order o = new Order();
        supplier s = new supplier();

        public Orders()
        {
            InitializeComponent();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            //Orders orderPage = new Orders();
           /// this.Hide();
          //  orderPage.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            txt_username.Text = "Shashika Idushan";

            //load data to the data grid
            DataTable dt = orderDBUtill.Select();
            orderListGrid.DataSource = dt;
            
       

        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            
        }






        

        private void testGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
           
        }




        //Grid Cell click event
        private void orderListGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            o.orderID = Convert.ToInt32(orderListGrid.Rows[rowIndex].Cells[0].Value.ToString());
         //   view_Order viewMyOD = new view_Order(o.orderID);
            //viewMyOD.Show();



        }



        //create order button click event
        private void btn_createOrder_Click(object sender, EventArgs e)
        {
            order_CreateOrder createOrder = new order_CreateOrder();
            createOrder.Show();
        }

        



        //------------------------------CONTEXT MENU----------------------------------------//
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_Order viewMyOD = new view_Order(o.orderID, s.supplierID);
            viewMyOD.Show();
        }

       

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string msg = "Do you want to delete this order? \n" + "Order ID : "+ o.orderID ;
            string title = "Delete Order";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(msg, title, buttons);
            if(result == DialogResult.Yes)
            {
                bool success = orderDBUtill.Delete(o);


                if (success == true)
                {
                    MessageBox.Show("Data has successfully deleted");
                    //load data to the data grid
                    DataTable dt = orderDBUtill.Select();
                    orderListGrid.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Failed to delete the data");
                }
            } else
            {
                DataTable dt = orderDBUtill.Select();
                orderListGrid.DataSource = dt;
            }
            
        }


        private void markAsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(o.status == "Pending")
            {
                bool success = orderDBUtill.completeOrder(o);

                if(success == true)
                {
                    MessageBox.Show("Order has marked as Completed");
                    DataTable dt = orderDBUtill.Select();
                    orderListGrid.DataSource = dt;
                } else
                {
                    MessageBox.Show("Please try again!");
                }
            } else
            {
                MessageBox.Show("This order has already Completed");
            }  
        }

        //------------------------------------------------------------------------------------------------//





        private void orderListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                int rowIndex = e.RowIndex;
                o.orderID = Convert.ToInt32(orderListGrid.Rows[rowIndex].Cells[0].Value.ToString());
                s.supplierID = orderListGrid.Rows[rowIndex].Cells[2].Value.ToString();
                o.status = orderListGrid.Rows[rowIndex].Cells[6].Value.ToString();


            } catch(Exception ex)
            {

            }
            
        }









        //--------------------------------------Search--------------------------//
        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            string key = txtBox_Search.Text;

            orderListGrid.DataSource = orderDBUtill.Search(key);

        }

        private void btn_Completed_Click(object sender, EventArgs e)
        {
            string key = "Completed";
            orderListGrid.DataSource = orderDBUtill.Search(key);
        }

        private void btn_Pending_Click(object sender, EventArgs e)
        {
            string key = "Pending";
            orderListGrid.DataSource = orderDBUtill.Search(key);
        }

        private void lbl_filter_Click(object sender, EventArgs e)
        {
            //load data to the data grid
            DataTable dt = orderDBUtill.Select();
            orderListGrid.DataSource = dt;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            orderDBUtill.getSupplier(ref s);


            DataTable orderDT = new DataTable();
            DataTable itemDT = new DataTable();

            orderDBUtill.SelectOrder(ref orderDT, ref itemDT, o.orderID);



            printOrder.Clear();

            printOrder.AddString("<h1>Invoice</h1>");

            printOrder.AddString("<h3>"+ s.name +"</h3>");
         //   printOrder.AddString("<h3>" + s.street + "</h3>");
            printOrder.AddString("<h3>" + s.email + "</h3>");
            printOrder.AddString("<h3>" + s.no + "</h3>");


            printOrder.AddDataTable(itemDT);


            printOrder.ShowPrintPreviewDialog();
        }
    }
}
