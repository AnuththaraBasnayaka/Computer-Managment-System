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
    public partial class ViewQuotation : Form
    {

        public static int oid;
        Customer c = new Customer();
        Quotation q = new Quotation();


        public ViewQuotation(int qid)
        {
            c.QID = qid;
            InitializeComponent();
        }

        private void view_Order_Load(object sender, EventArgs e)
        {
            DataTable QuotationItemDT = new DataTable();
            DataTable CustomerDT = new DataTable();

            QuotationDBUtil.SelectQuotation(ref QuotationItemDT, ref CustomerDT, c.QID);

            foreach(DataRow dr in CustomerDT.Rows)
            {
                c.Name = dr["CustomerName"].ToString();
                c.Date = dr["Date"].ToString();
                c.No = dr["TeleNo"].ToString();
                c.Email = dr["Email"].ToString();
                c.Address = dr["Address"].ToString();
                c.TotalAmount= (dr["TotalAmount"].ToString());

                MessageBox.Show(dr["TotalAmount"].ToString());
                
            }

            lbl_nameCustomer.Text = c.Name;
            lbl_qid.Text = c.QID.ToString();
            lbl_TeleNo.Text = c.No;
            lbl_Email.Text = c.Email;
            lbl_address.Text = c.Address;
            lbl_date.Text = c.Date;
            lbl_totAmount.Text = c.TotalAmount;


            QuotationItemGrid.DataSource = QuotationItemDT;
            QuotationItemGrid.Columns[0].ReadOnly = true;
            QuotationItemGrid.Columns[1].ReadOnly = true;






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

        public static int total;
        public static int amount;
        private void btn_UpdateQ_Click(object sender, EventArgs e)
        {

           // Quotation q = new Quotation();


            int tot = 0;
            amount = 0;
            

            try
            {
                for (int rows = 0; rows < QuotationItemGrid.Rows.Count; rows++)
                {
                    string sQty = QuotationItemGrid.Rows[rows].Cells[4].Value.ToString();
                    string sUnitPrice = QuotationItemGrid.Rows[rows].Cells[5].Value.ToString();

                    int Tqty = Convert.ToInt32(sQty);
                    int UPrice = Convert.ToInt32(sUnitPrice);


                    amount = (UPrice * Tqty);
                    tot = tot + amount ;

                    QuotationItemGrid.Rows[rows].Cells[6].Value = amount;
                }


                lbl_totAmount.Text = tot.ToString();
                

                //Qtotalamount.Text = Convert.ToString(amount);
                c.TotalAmount = Convert.ToString(tot);



                //Save data grid into a DataTable
                DataTable dt = new DataTable();
                for (int i = 0; i < QuotationItemGrid.Columns.Count; i++)
                {
                    dt.Columns.Add("column" + i.ToString());
                }

                foreach (DataGridViewRow row in QuotationItemGrid.Rows)
                {
                    DataRow dr = dt.NewRow();

                    for (int j = 0; j < QuotationItemGrid.Columns.Count; j++)
                    {
                        dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                    }

                    dt.Rows.Add(dr);

                }

                q.dataTable = dt;


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter the value again");
            }


            q.QID = Convert.ToInt32(lbl_qid.Text);
            q.TotalAmount = tot.ToString();


            bool success1 = QuotationDBUtil.UpdateQuotationItems(q);
            bool success2 = QuotationDBUtil.quotationUpdate(q);



            if (success1 == true && success2 == true)
            {
                MessageBox.Show("Data has successfully updated");

            }
            else
            {
                MessageBox.Show("Failed to insert the data");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void QuotationItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuotationItemGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_deleteQ_Click(object sender, EventArgs e)
        {
            bool isSuccess = QuotationDBUtil.Delete(c.QID);

            if(isSuccess == true)
            {
                MessageBox.Show("Quation has successfully deleted");
                this.Close();
            } else
            {
                MessageBox.Show("Failed to delete the quoation");
            }
        }

        private void btn_printQ_Click(object sender, EventArgs e)
        {
            DataTable QuotationItemDT = new DataTable();
            DataTable CustomerDT = new DataTable();

            int qid = c.QID;

            QuotationDBUtil.SelectQuotation(ref QuotationItemDT, ref CustomerDT, qid);


            printQuotation.Clear();
            printQuotation.AddImage(imgLogo.Image, "width= 150, style='float:right'");
            printQuotation.AddHorizontalRule();

            printQuotation.AddString("<h1>NewTech Quotation</h1><br><br>");
            printQuotation.AddHorizontalRule();

            printQuotation.AddString("<h4>" + c.Name + "</h4>");
            printQuotation.AddString("<h4>" + c.No + "</h4>");
            printQuotation.AddString("<h4>" + c.Email + "</h4>");
            printQuotation.AddString("<h4>" + c.Address + "</h4>");
            printQuotation.AddString("<h4>" + c.Date + "</h4><br>");
            printQuotation.AddDataTable(QuotationItemDT);

            printQuotation.AddString("<br><h2><div style='float:right;margin-top;'> Total Amount : Rs. " + c.TotalAmount + ".00</div></h2>");
          
            printQuotation.ShowPrintPreviewDialog();
        }
    }
}
