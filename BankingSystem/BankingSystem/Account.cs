using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Account
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public List<Transaction> Transactions { get; set; }


        public Account() { }
        public Account(int accNo, string name, int bal)
        {
            AccNo = accNo;
            Name = name;
            Balance = bal;
            Transactions = new List<Transaction>();
        }
        public override string ToString()
        {
            return "AccountNo:- " + AccNo + " Name:- " + Name + " Balance:- " + Balance;
        }
        public void DisplayTransaction()
        {
            foreach (Transaction t in Transactions)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}
