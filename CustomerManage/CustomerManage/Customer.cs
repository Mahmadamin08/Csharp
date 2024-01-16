using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Location { get; set; }
        public int MobNo { get; set; }
        public Age age { get; set; }

        public Customer(int cid, string name, DateTime dob, string loc, int mno, Age ag)
        {
            CustomerID = cid;
            Name = name;
            DateTime Dob = dob;
            Location = loc;
            MobNo = mno;
            Age age = ag;
        }

        public override string ToString()
        {
            return "CustomerID " + CustomerID + " Name " + Name + " DOB " + Dob + " Location " + Location + " MobileNo " + MobNo + " Age " + age.ToString();
        }
    }
}
