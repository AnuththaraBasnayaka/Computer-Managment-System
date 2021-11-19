using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Managment_System.Classes
{
    class Customer
    {
        
        public int QID { get; set; }
        public string Name { get; set; }
        public string No { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
        public string TotalAmount { get; set; }
        public DataTable dataTable { get; set; }
    }
}
