using Computer_Managment_System.Classes.Anuththara;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System.Forms.Anuththara
{
    public partial class ServiceRepair_View : Form
    {
        public ServiceRepair_View()
        {
            InitializeComponent();
        }

        repairsearchClass r = new repairsearchClass();

        private void btn_viewClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusService_Search_TextChanged(object sender, EventArgs e)
        {
            String keyWord = statusService_Search.Text;
            dgv_statusSeviceView.DataSource = repairsearchClass.statusDetSearch(keyWord);
        }

        private void serviceDetails_Search_TextChanged(object sender, EventArgs e)
        {
            String keyWord = serviceDetails_Search.Text;
            dgv_service.DataSource = repairsearchClass.searviceDetSearch(keyWord);
        }

        private void repairDetails_Search_TextChanged(object sender, EventArgs e)
        {
            String keyWord = repairDetails_Search.Text;
            dgv_repairDetails.DataSource = repairsearchClass.repairDetSearch(keyWord);
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
