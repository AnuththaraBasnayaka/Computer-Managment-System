using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Managment_System.Classes
{
    class date
    {
        public string date1 { get; set; }
        public string date2 { get; set; }



        public static date createDate(string year, string month)
        {
            date d = new date();

            switch (month)
            {
                case "January":
                    d.date1 = year + "-" + "01" + "-" + "01";
                    d.date2 = year + "-" + "01" + "-" + "31";
                    break;

                case "February":
                    d.date1 = year + "-" + "02" + "-" + "01";
                    d.date2 = year + "-" + "02" + "-" + "28";
                    break;

                case "March":
                    d.date1 = year + "-" + "03" + "-" + "01";
                    d.date2 = year + "-" + "03" + "-" + "31";
                    break;

                case "April":
                    d.date1 = year + "-" + "04" + "-" + "01";
                    d.date2 = year + "-" + "04" + "-" + "30";
                    break;
                case "May":
                    d.date1 = year + "-" + "05" + "-" + "01";
                    d.date2 = year + "-" + "05" + "-" + "31";
                    break;

                case "June":
                    d.date1 = year + "-" + "06" + "-" + "01";
                    d.date2 = year + "-" + "06" + "-" + "30";
                    break;

                case "July":
                    d.date1 = year + "-" + "07" + "-" + "01";
                    d.date2 = year + "-" + "07" + "-" + "31";
                    break;

                case "August":
                    d.date1 = year + "-" + "08" + "-" + "01";
                    d.date2 = year + "-" + "08" + "-" + "31";
                    break;
                case "September":
                    d.date1 = year + "-" + "09" + "-" + "01";
                    d.date2 = year + "-" + "09" + "-" + "30";
                    break;

                case "October":
                    d.date1 = year + "-" + "10" + "-" + "01";
                    d.date2 = year + "-" + "10" + "-" + "31";
                    break;

                case "November":
                    d.date1 = year + "-" + "11" + "-" + "01";
                    d.date2 = year + "-" + "11" + "-" + "30";
                    break;

                case "December":
                    d.date1 = year + "-" + "12" + "-" + "01";
                    d.date2 = year + "-" + "12" + "-" + "31";
                    break;

            }


            return d;
        }

    }
}
