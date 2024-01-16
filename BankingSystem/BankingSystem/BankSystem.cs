using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class BankSystem
    {
        Dictionary<int, Account> accounts;

        Dictionary<int, Transaction> transactions;

        public BankSystem()
        {
            accounts = new Dictionary<int, Account>();
            transactions = new Dictionary<int, Transaction>();
        }
        public Account InputAcc()
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            int accNo = int.Parse(arr[0]);
            string name = arr[1];
            int bal = int.Parse(arr[2]);

            return new Account(accNo, name, bal);
        }
        public Transfer InputTransfer()
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            int acc1 = int.Parse(arr[0]);
            int acc2 = int.Parse(arr[1]);
            int amt = int.Parse(arr[2]);

            return new Transfer(acc1, acc2, amt);
        }
        public int InputInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public void AddAccount(Account account)
        {
            if (accounts.ContainsKey(account.AccNo))
            {
                Console.WriteLine("Already have accout");
                return;
            }
            accounts.Add(account.AccNo, account);
        }

        public void DisplayAllAccount()
        {
            foreach (Account account in accounts.Values)
            {
                Console.WriteLine(account.ToString());
            }
        }

        public void TransferMoney(Transfer transfer)
        {
            if (!accounts.ContainsKey(transfer.acc1))
            {
                Console.WriteLine("Account 1 not Available!!");
                return;
            }
            if (!accounts.ContainsKey(transfer.acc2))
            {
                Console.WriteLine("Account 2 not Available!!");
                return;
            }
            Random rnd = new Random();
            int tranId = rnd.Next();
            foreach (Account account in accounts.Values)
            {
                if (account.AccNo == transfer.acc1)
                {
                    if (account.Balance >= transfer.amount)
                    {
                        Console.WriteLine("Not Enough Balance");
                        return;
                    }
                    account.Balance -= transfer.amount;
                    Transaction s = new Transaction(tranId, transfer.acc1, transfer.acc2, true, transfer.amount, DateTime.Now);
                    account.Transactions.Add(s);
                }
                if (account.AccNo == transfer.acc2)
                {
                    account.Balance += transfer.amount;
                    Transaction s = new Transaction(tranId, transfer.acc1, transfer.acc2, false, transfer.amount, DateTime.Now);
                    account.Transactions.Add(s);
                }
            }
        }

        public List<Transaction> getAllTransactionByAccNo(int accNo)
        {
            foreach (Account account in accounts.Values)
            {
                if (account.AccNo == accNo)
                {
                    DisplayTransaction(account.Transactions);
                    return account.Transactions;
                }
            }
            Console.WriteLine("Account Not Found!!");
            return null;
        }

        public void DisplayTransaction(List<Transaction> t)
        {
            foreach (Transaction s in t)
                Console.WriteLine(s.ToString());
        }
    }
}
