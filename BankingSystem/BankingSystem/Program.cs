// See https://aka.ms/new-console-template for more inform

using BankingSystem;

BankSystem bs = new BankSystem();
Console.WriteLine(DateTime.Now);
while (true)
{
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            bs.AddAccount(bs.InputAcc());
            continue;
        case 2:
            bs.DisplayAllAccount();
            continue;
        case 3:
            bs.TransferMoney(bs.InputTransfer());
            continue;
        case 4:
            bs.getAllTransactionByAccNo(bs.InputInt());
            continue;
        case 5:
            break;
    }
}