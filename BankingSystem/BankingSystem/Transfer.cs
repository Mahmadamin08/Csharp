using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Transfer
    {
        public int acc1 { get; set; }
        public int acc2 { get; set; }
        public int amount { get; set; }
        public Transfer() { }
        public Transfer(int acc1, int acc2, int amt)
        {
            this.acc1 = acc1;
            this.acc2 = acc2;
            this.amount = amt;
        }
    }
}
