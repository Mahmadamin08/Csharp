using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage
{
    internal class CustomerSyatem
    {
        public List<Customer> _list { get; set; }
        public static int CustomerID = 100000;

        public CustomerSyatem()
        {
            _list = new List<Customer>();
        }
        public Customer InpCustomer()
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            string name = arr[0];
            int mobNo = Convert.ToInt32(arr[1]);
            string loc = arr[2];
 
            return new Customer(CustomerID, name, dob, loc, mobNo, CalculateAge(dob));

        }
        public Age CalculateAge(DateTime dob)
        {
            DateTime now = DateTime.Now;
            int year = now.Year - dob.Year;
            int month = now.Month - dob.Month;

            if (month < 0)
            {
                month = 12 + month;
                year--;
            }
            return new Age(year, month);
        }
        public void AddCustomer(Customer customer)
        {
            CustomerID++;
            _list.Add(customer);
        }
        public void DisplayCustomer()
        {
            foreach (Customer customer in _list)
            {
                Console.WriteLine(customer.ToString());
            }
        }

    }
}
