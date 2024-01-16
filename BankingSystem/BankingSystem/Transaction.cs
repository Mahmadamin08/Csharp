using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Transaction
    {
        public int TransactionID { get; set; }
        public int AccountFrom { get; set; }
        public int AccountTo { get; set; }
        public bool isDebit { get; set; }
        public int Amount { get; set; }
        public DateTime DateAndTime { get; set; }

        public Transaction() { }
        public Transaction(int tid, int accno, int accto, bool isDeb, int amount, DateTime dateAndTime)
        {
            TransactionID = tid;
            AccountFrom = accno;
            AccountTo = accto;
            isDebit = isDeb;
            Amount = amount;
            DateAndTime = dateAndTime;
        }

        public override string ToString()
        {
            if (isDebit)
            {
                return "TransactionId:- " + TransactionID + "\n " + Amount + " " + "Debited From " + AccountFrom + " To " + AccountTo + " on " + DateAndTime;
            }
            return "TransactionId:- " + TransactionID + " \n " + Amount + " " + "Creadit To " + AccountTo + " From " + AccountFrom + " on " + DateAndTime;
        }
    }
}
