using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Managment_System.Classes
{
    class Quotation
    {
        public int QID { get; set; }
        public string Date { get; set; }
        public string ItemcodeQ { get; set; }
        public string ItemnameQ { get; set; }
        public string BrandQ { get; set; }
        public string CatergoryQ { get; set; }
        public string Total { get; set; }
        public string TotalAmount { get; set; }

        public DataTable dataTable { get; set; }
    }
}
