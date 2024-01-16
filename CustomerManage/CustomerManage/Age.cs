using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage
{
    internal class Age
    {
        public int year { get; set; }
        public int month { get; set; }

        public Age() { }
        public Age(int year, int month)
        {
            this.year = year;
            this.month = month;
        }
        public override string ToString()
        {
            return year + " Years " + month + " Month ";
        }
    }
}
