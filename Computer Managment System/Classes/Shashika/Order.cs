using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Managment_System.Classes
{
    class Order
    {
        public int orderID { get; set; }
        public string date { get; set; }
        public string sid { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public int tot { get; set; }
        public string status { get; set; }
        public DataTable dataTable { get; set; }


    }
}
