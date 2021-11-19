using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_Managment_System.Classes;
using Computer_Managment_System.Forms.Kavindi;
using Computer_Managment_System.Forms.Shashika;




namespace Computer_Managment_System
{
    public partial class Dashboard : Form
    {
        public static string UserName;


        Order o = new Order();
        supplier s = new supplier();


        supplierDBUtill c = new supplierDBUtill();


        paymentdata p = new paymentdata();



        public Dashboard(string uname)
        {
            UserName = uname;
            InitializeComponent();
        }

        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            txt_username.Text = UserName;


            //load data to the data grid - Shashika
            DataTable dt = orderDBUtill.Select();
            orderListGrid.DataSource = dt;




            //Loard Data on Data GrideView - Punsisi
            DataTable p_dt = p.Select();
            EmployeePaymentdataGridView.DataSource = p_dt;

        }
















        


        /*-----------------------------------------------------------------Page Navigation---------------------------------------------------------*/

        private void btn_Home_Click(object sender, EventArgs e)
        {
            ManagerDashboardPages.SetPage("Home");
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            ManagerDashboardPages.SetPage("Suppliers");
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            ManagerDashboardPages.SetPage("Salary");
        }
        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            ManagerDashboardPages.SetPage("Orders");
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ManagerDashboardPages.SetPage("Reports");
        }





        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
        /*-------------------------------------------------------------- Idushan K.A.S - IT20118068 -----------------------------------------------------------*/


        //Grid Cell Click Event
        private void orderListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            o.orderID = Convert.ToInt32(orderListGrid.Rows[rowIndex].Cells[0].Value.ToString());
            s.supplierID = orderListGrid.Rows[rowIndex].Cells[2].Value.ToString();
            o.status = orderListGrid.Rows[rowIndex].Cells[6].Value.ToString();
        }


        //Button - Create Order
        private void btn_createOrder_Click(object sender, EventArgs e)
        {
            order_CreateOrder createOrder = new order_CreateOrder();
            createOrder.Show();
        }


        //Button - Completed
        private void btn_Completed_Click(object sender, EventArgs e)
        {
            string key = "Completed";
            orderListGrid.DataSource = orderDBUtill.Search(key);
        }

        //Button - Pending
        private void btn_Pending_Click(object sender, EventArgs e)
        {
            string key = "Pending";
            orderListGrid.DataSource = orderDBUtill.Search(key);
        }


        //Search
        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = orderDBUtill.Search(txtBox_Search.Text);
            orderListGrid.DataSource = dt;
        }



        //Label - Clear Filter
        private void lbl_filter_Click(object sender, EventArgs e)
        {
            //load data to the data grid
            DataTable dt = orderDBUtill.Select();
            orderListGrid.DataSource = dt;
        }

        //-------------------
        //Context Menu Items
        //-------------------

        //1. Mark as completed
        private void markAsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (o.status == "Pending")
            {
                bool success = orderDBUtill.completeOrder(o);

                if (success == true)
                {
                    MessageBox.Show("Order has marked as Completed");
                    DataTable dt = orderDBUtill.Select();
                    orderListGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Please try again!");
                }
            }
            else
            {
                MessageBox.Show("This order has already Completed");
            }
        }


        //2. View order
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_Order viewMyOD = new view_Order(o.orderID, s.supplierID);
            viewMyOD.Show();
        }


        //3. Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderDBUtill.getSupplier(ref s);



            int tot = 0;


            

            DataTable orderDT = new DataTable();
            DataTable itemDT = new DataTable();

            orderDBUtill.SelectOrder(ref orderDT, ref itemDT, o.orderID);


            foreach (DataRow dr in orderDT.Rows)
            {
                tot = Convert.ToInt32(dr["Amount"].ToString());
            }


            printOrder.Clear();



            printOrder.AddImage(imgLogo.Image, "width= 150, style='float:right'");
            printOrder.AddHorizontalRule();

            printOrder.AddString("<h1>Invoice</h1>");

            printOrder.AddHorizontalRule();

            printOrder.AddLineBreak();
            printOrder.AddLineBreak();



            printOrder.AddString("<h3>" + s.name + "</h3>");     
            printOrder.AddString("<h3>" + s.email + "</h3>");
            printOrder.AddString("<h3>" + s.no + "</h3>");


            printOrder.AddDataTable(itemDT);
            printOrder.AddLineBreak();

            printOrder.AddString("<br><h3><div style='float:right;margin-top;'> Amount : Rs. " + tot + "</div></h3>");

            printOrder.ShowPrintPreviewDialog();
        }


        //4. Delete
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to delete this order? \n" + "Order ID : " + o.orderID;
            string title = "Delete Order";

            //YesNo message box
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(msg, title, buttons);
            if (result == DialogResult.Yes)
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
            }
            else
            {
                DataTable dt = orderDBUtill.Select();
                orderListGrid.DataSource = dt;
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }




        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
        /*-------------------------------------------------------------- Kavindi - ITxxxxxxx -----------------------------------------------------------*/



        private void btn_Add_Suppliers_Click(object sender, EventArgs e)
        {


            if (validate_emailaddress.IsMatch(textBoxEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxEmail.Focus();
                return;
            } else
            {
                // Get the values from the input fields
                c.SupplierName = textBoxName.Text;
                c.BrandName = textBoxBrand.Text;
                c.ContactNo = textBoxContact.Text;
                c.Email = textBoxEmail.Text;
                c.Address = textBoxAddress.Text;


                // Insert data into database using the method created in previous
                bool success = c.Insert(c);


                if (success == true)
                {
                    // Successfully Inserted Message
                    MessageBox.Show("New Supplier Inserted Successfully!");


                    // Call the Clear method
                    Clear();



                    supplierUpdate log1 = new supplierUpdate();
                    log1.Show();


                }
                else
                {

                    // Failed Inserted Message
                    MessageBox.Show("Failed to add New Supplier.Try Again!");

                }
            }

            
        }

        private void btn_ViewSuppliers_Click(object sender, EventArgs e)
        {
            supplierUpdate supplierList = new supplierUpdate();
            supplierList.Show();
        }




        // Method to Clear fields

        public void Clear()
        {
            textBoxName.Text = "";
            textBoxBrand.Text = "";
            textBoxContact.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
        }


        // Email Validation

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }




        static Regex validate_emailaddress = email_validation();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }












        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
        /*-------------------------------------------------------------- Punsisi - ITxxxxxxx -----------------------------------------------------------*/


        public void PKClear()
        {
            txtpayment.Text = "";
            txtEmpid.Text = "";
            txtnic.Text = "";
            txtpdate.Text = "";
            comboBox1.Text = "";
            txtChour.Text = "";
            txtOhour.Text = "";
            txtCrate.Text = "";
            txtOrate.Text = "";
            txtTotHour.Text = "";
            txtCearn.Text = "";
            txtOearn.Text = "";
            txtTotPay.Text = "";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }




        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SearchPayment objSearchPayment = new SearchPayment();
            
            objSearchPayment.Show();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //Call clear method here
            PKClear();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtpayment.Text) || String.IsNullOrEmpty(txtEmpid.Text) || String.IsNullOrEmpty(txtnic.Text) || String.IsNullOrEmpty(txtOhour.Text) || String.IsNullOrEmpty(txtCrate.Text) || String.IsNullOrEmpty(txtOrate.Text) || String.IsNullOrEmpty(txtpdate.Text) || String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please Enter the details again");
            } else
            {
                int distance;
                if (int.TryParse(txtChour.Text, out distance) && int.TryParse(txtOhour.Text, out distance) && int.TryParse(txtCrate.Text, out distance) && int.TryParse(txtOrate.Text, out distance))
                {
                   

                    double contractualHour = Convert.ToDouble(txtChour.Text);
                    double overtimeHour = Convert.ToDouble(txtOhour.Text);
                    double contractualRate = Convert.ToDouble(txtCrate.Text);
                    double overtimeRate = Convert.ToDouble(txtOrate.Text);

                    double totalHour = contractualHour + overtimeHour;
                    double contractualEarning = contractualHour * contractualRate;
                    double overtimeEarning = overtimeHour * overtimeRate;
                    double totalPay = contractualEarning + overtimeEarning;

                    txtTotHour.Text = totalHour.ToString();
                    txtTotPay.Text = totalPay.ToString();
                    txtCearn.Text = contractualEarning.ToString();
                    txtOearn.Text = overtimeEarning.ToString();

                } else
                {
                    MessageBox.Show("Please Enter valid details");
                }

                
            }

            
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Get the value from the input fields
                p.PaymentID = Convert.ToInt32(txtpayment.Text);
                p.EmployeeID = txtEmpid.Text;
                p.NIC = txtnic.Text;
                p.PayDate = txtpdate.Text;
                p.PayMonth = comboBox1.Text;
                p.ContractualHour = float.Parse(txtChour.Text);
                p.OvertimeHour = float.Parse(txtOhour.Text);
                p.ContractualRate = float.Parse(txtCrate.Text);
                p.OvertimeRate = float.Parse(txtOrate.Text);
                p.TotalHour = float.Parse(txtTotHour.Text);
                p.ContractualEarning = float.Parse(txtCearn.Text);
                p.OvertimeEarning = float.Parse(txtOearn.Text);
                p.TotalPay = float.Parse(txtTotPay.Text);



                //MessageBox.Show(p.TotalPay.ToString());

                //Inserting data into database using the method create paymentdata class
                bool success = p.Insert(p);
                if (success == true)
                {

                    //Successfully Inserted
                    MessageBox.Show("New Payment Details Successfully Inserted");
                    //Call the clear method here
                    PKClear();

                }
                else
                {

                    //Failed to Add Employee payment details
                    MessageBox.Show("Failed to Add Employee Payment Details. Try Again!");
                }

                //Loard Data on Data GrideView
                DataTable dt = p.Select();
                EmployeePaymentdataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Enter the Values");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Get the data from textboxes
                p.PaymentID = Convert.ToInt32(txtpayment.Text);
                p.EmployeeID = txtEmpid.Text;
                p.NIC = txtnic.Text;
                p.PayDate = txtpdate.Text;
                p.PayMonth = comboBox1.Text;
                p.ContractualHour = float.Parse(txtChour.Text);
                p.OvertimeHour = float.Parse(txtOhour.Text);
                p.ContractualRate = float.Parse(txtCrate.Text);
                p.OvertimeRate = float.Parse(txtOrate.Text);
                p.TotalHour = float.Parse(txtTotHour.Text);
                p.ContractualEarning = float.Parse(txtCearn.Text);
                p.OvertimeEarning = float.Parse(txtOearn.Text);
                p.TotalPay = float.Parse(txtTotPay.Text);
                //Update data in database

                bool success = p.Update(p);
                if (success == true)
                {
                    //Updated Successfully
                    MessageBox.Show("Payment Details has been successfully Updated.");

                    //Loard Data on Data GrideView
                    DataTable dt = p.Select();
                    EmployeePaymentdataGridView.DataSource = dt;
                    //Call Clear Method
                    PKClear();

                }
                else
                {
                    //Failed to Update
                    MessageBox.Show("Failed to Update Payment Details. Try Again!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter the Value");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //Get the PaymentID from the textboxes
            p.PaymentID = Convert.ToInt32(txtpayment.Text);

            bool success = p.Delete(p);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Payment Successfully Deleted");
                //Refresh Data grid view
                //Loard Data on Data GrideView
                DataTable dt = p.Select();
                EmployeePaymentdataGridView.DataSource = dt;
                //Call Clear Method
                PKClear();
            }
            else
            {
                //Failed to Deleted
                MessageBox.Show("Failed to Delete. Try Again!");
            }
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {

        }




        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Report Generate

            DataTable dt = new DataTable();

            //Get the Emplyee name from Employee table.
              string ename = paymentdata.GetEmployeeName(p.EmployeeID);



            //Get the data from textboxes
            p.PaymentID = Convert.ToInt32(txtpayment.Text);
            p.EmployeeID = txtEmpid.Text;
            p.NIC = txtnic.Text;
            p.PayDate = txtpdate.Text;
            p.PayMonth = comboBox1.Text;
            p.ContractualHour = float.Parse(txtChour.Text);
            p.OvertimeHour = float.Parse(txtOhour.Text);
            p.ContractualRate = float.Parse(txtCrate.Text);
            p.OvertimeRate = float.Parse(txtOrate.Text);
            p.TotalHour = float.Parse(txtTotHour.Text);
            p.ContractualEarning = float.Parse(txtCearn.Text);
            p.OvertimeEarning = float.Parse(txtOearn.Text);
            p.TotalPay = float.Parse(txtTotPay.Text);





            printSalary.AddImage(imgLogo.Image, "width= 150, style='float:right'");
            printSalary.AddHorizontalRule();

            printSalary.AddString("<h1><b>Salary Report</b></h1><br>");
            printSalary.AddHorizontalRule();


        
            printSalary.AddLineBreak();
            dt.Columns.Add("Employee Salary Details");
            dt.Columns.Add("Details");

            dt.Rows.Add(new object[] { "Employee Name ", ename });
            dt.Rows.Add(new object[] { "Employee ID ", p.EmployeeID });
            dt.Rows.Add(new object[] { "Contractual Hours ", p.ContractualHour });
            dt.Rows.Add(new object[] { "Contracual Rate ", p.ContractualRate });
            dt.Rows.Add(new object[] { "Contracual Earnings ", p.ContractualEarning });
            dt.Rows.Add(new object[] { "Over-Time Hours ", p.OvertimeHour });
            dt.Rows.Add(new object[] { "Over-Time Rate ", p.OvertimeRate });
            dt.Rows.Add(new object[] { "Over-Time Earnings ", p.OvertimeEarning });
          //  dt.Rows.Add(new object[] { "<h2>Total Payments</h2>", p.TotalPay + "<br>" });

            printSalary.AddLineBreak();
            //printSalary.AddHorizontalRule();
            printSalary.AddLineBreak();

            printSalary.AddDataTable(dt);

            printSalary.AddString("<br><h2><div style='float:right;margin-top;'> Total Amount : Rs. " + p.TotalPay + ".00</div></h2>");

            printSalary.ShowPrintPreviewDialog();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void EmployeePaymentdataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the textbox respectively
            //Identify the row on which mouse is clicked

            int rowIndex = e.RowIndex;
            txtpayment.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            txtEmpid.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            txtnic.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            txtpdate.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            comboBox1.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            txtChour.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            txtOhour.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            txtCrate.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[7].Value.ToString();
            txtOrate.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[8].Value.ToString();
            txtTotHour.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[9].Value.ToString();
            txtCearn.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[10].Value.ToString();
            txtOearn.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[11].Value.ToString();
            txtTotPay.Text = EmployeePaymentdataGridView.Rows[rowIndex].Cells[12].Value.ToString();
        }

        









        //Generate Financial Report
        private void bunifuButton22_Click(object sender, EventArgs e)
        {


            //Save data grid into a DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < financialReport.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in financialReport.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < financialReport.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }

            dt.Columns["column0"].ColumnName = "Activity";
            dt.Columns["column1"].ColumnName = "Amount";


            printFinancial.Clear();



            printFinancial.AddImage(imgLogo.Image, "width= 150, style='float:right'");
            printFinancial.AddHorizontalRule();

            printFinancial.AddString("<h1>Monthly Report " + cmbBox_month.Text + " " + txtbox_year.Text + "</h1>");
            printFinancial.AddHorizontalRule();

            printFinancial.AddLineBreak();
            printFinancial.AddLineBreak();



            printFinancial.AddDataTable(dt);
            printFinancial.AddString("<br><h2><div style='float:right;margin-top;'>" + lbl_financialTot.Text + "</div></h2>");
          



            printFinancial.ShowPrintPreviewDialog();


        }

        private void btn_repView_Click(object sender, EventArgs e)
        {
            financialReport.Rows.Clear();
            financialReport.Refresh();

            Financial ft = new Financial();
            date dt = new date();

            string year = txtbox_year.Text;
            string month = cmbBox_month.Text;



            if(String.IsNullOrEmpty(txtbox_year.Text) || String.IsNullOrEmpty(cmbBox_month.Text))
            {
                MessageBox.Show("Please enter the values again");
            } else
            {
                dt = date.createDate(year, month);



                ft = Financial.financialCalc(dt.date1, dt.date2);


                int n = financialReport.Rows.Add();
                financialReport.Rows[n].Cells[0].Value = "Paid for invoices";
                financialReport.Rows[n].Cells[1].Value = ft.totInvoices;



                n = financialReport.Rows.Add();
                financialReport.Rows[n].Cells[0].Value = "Paid for Suppliers";
                financialReport.Rows[n].Cells[1].Value = ft.totOrders;


                n = financialReport.Rows.Add();
                financialReport.Rows[n].Cells[0].Value = "Paid Salaries of employees";
                financialReport.Rows[n].Cells[1].Value = ft.totSal;

                int tot = 0;




                int numericValue;

                if(int.TryParse(ft.totInvoices, out numericValue) && int.TryParse(ft.totOrders, out numericValue) && int.TryParse(ft.totSal, out numericValue))
                {
                    tot = Int32.Parse(ft.totInvoices) + Int32.Parse(ft.totOrders) + Int32.Parse(ft.totSal);
                } else
                {
                    tot = 0;
                }                     

                lbl_financialTot.Text = "TOTAL : Rs." + tot.ToString();

            }
            
        }

        private void btn_monthlyRep_Click(object sender, EventArgs e)
        {
            printSupplierRep supRep = new printSupplierRep();

            supRep.Show();
        }

        private void btn_orderMonthlyRep_Click(object sender, EventArgs e)
        {
            ordersMonthlyRep lg_monthly = new ordersMonthlyRep();
            lg_monthly.Show();


        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
