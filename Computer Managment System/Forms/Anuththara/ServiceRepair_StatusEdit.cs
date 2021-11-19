using Computer_Managment_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System
{
    public partial class ServiceRepair_StatusEdit : Form
    {
        public ServiceRepair_StatusEdit()
        {
            InitializeComponent();
        }

        servicestatusClass s = new servicestatusClass();

        

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Clear all the Feilds
        public void Clear()
        {
            txt_ServiceID.Text = "";
            txt_ServiceName.Text = "";
            txt_ServiceType.Text = "";
            txt_ServiceOwner.Text = "";
            txt_Duration.Text = "";
        }

      
        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            s.ServiceName = txt_ServiceName.Text;
            s.ServiceType = txt_ServiceType.Text;
            s.ServiceOwner = txt_ServiceOwner.Text;
            s.Duration = txt_Duration.Text;


            //Inserting the Data into Database using the method we create in the java class
            bool success = s.Insert(s);
            if (success == true)
            {
                //Successfully Inserted 
                MessageBox.Show("New Srvice Add Successfully Inserted");
                //call the Clear method 
                Clear();
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add new Service,Try Again!");
            }
            //Load Data on Data GridView
            DataTable dt = s.Select(); //Method that in java class
            dvg_EditServiceStatus.DataSource = dt; //Laod new data inserted
        }

        private void btn_updateStatus_Click(object sender, EventArgs e)
        {
            s.ServiceID = Convert.ToInt32(txt_ServiceID.Text);
            s.ServiceName = txt_ServiceName.Text;
            s.ServiceType = txt_ServiceType.Text;
            s.ServiceOwner = txt_ServiceOwner.Text;
            s.Duration = txt_Duration.Text;

            //Update Data in Database
            bool success = s.Update(s);
            if (success == true)
            {
                //Successfully Inserted 
                MessageBox.Show("Details Successfully Updated");
                //call the Clear method 
                Clear();
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to update Details ,Try Again!");
            }
            //Load Data on Data GridView
            DataTable dt = s.Select(); //Method that in java class
            dvg_EditServiceStatus.DataSource = dt; //Laod new data inserted
        }

        private void btn_deleteStatus_Click(object sender, EventArgs e)
        {
            //Get the ServiceID from the Application
            s.ServiceID = Convert.ToInt32(txt_ServiceID.Text);
            bool success = s.Delete(s);
            if (success == true)
            {
                //Successfully Inserted 
                MessageBox.Show("Service details Successfully Deleted");
                //call the Clear method 
                Clear();
                //Refresh Data on Data GridView
                DataTable dt = s.Select(); //Method that in java class
                dvg_EditServiceStatus.DataSource = dt; //Laod new data inserted 

            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to Delete  Contact,Try Again!");
            }
        }

        private void btn_clearStatus_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ServiceRepair_NewRepairEditStatus_Load(object sender, EventArgs e)
        {
            DataTable dt = s.Select(); //Method that in java class
            dvg_EditServiceStatus.DataSource = dt; //Laod new data inserted
        }

        private void dgv_EditServiceStatus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data from data grid View and laod it to the textboxes respectively
            //Identify the row on which mouse id click
            int rowIndex = e.RowIndex;

            txt_ServiceID.Text = dvg_EditServiceStatus.Rows[rowIndex].Cells[0].Value.ToString();
            txt_ServiceName.Text = dvg_EditServiceStatus.Rows[rowIndex].Cells[1].Value.ToString();
            txt_ServiceType.Text = dvg_EditServiceStatus.Rows[rowIndex].Cells[2].Value.ToString();
            txt_ServiceOwner.Text = dvg_EditServiceStatus.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Duration.Text = dvg_EditServiceStatus.Rows[rowIndex].Cells[4].Value.ToString();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txt_SearchAddnewrepair_TextChanged(object sender, EventArgs e)
        {
            //Get the value from text box 
            string keyword = txt_SearchAddnewrepair.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_status WHERE ServiceID LIKE '%" + keyword + "%' OR ServiceName LIKE '%" + keyword + "%' OR ServiceType LIKE '%" + keyword + "%' OR ServiceOwner LIKE '%" + keyword + "%' OR Duration LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dvg_EditServiceStatus.DataSource = dt;
        }


        //get the details in the table into textboxes
        private void dvg_EditServiceStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get data if rows are not null
            if (dvg_EditServiceStatus.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dvg_EditServiceStatus.CurrentRow.Selected = true;

                //get ech row into each textbox
                txt_ServiceID.Text = dvg_EditServiceStatus.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_ServiceName.Text = dvg_EditServiceStatus.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_ServiceType.Text = dvg_EditServiceStatus.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_ServiceOwner.Text = dvg_EditServiceStatus.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_Duration.Text = dvg_EditServiceStatus.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
