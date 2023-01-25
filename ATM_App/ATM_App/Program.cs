using Practice;
int operation;
Console.WriteLine("Ente Number Beside the Operation To Perform : ");
Console.WriteLine("1.Balance Enquiry\n2.WithDraw Amount\n3.Deposit Amount\n4.Mini Statement\n5.Change Pin");
operation = Convert.ToInt32(Console.ReadLine());
switch (operation)
{
    case 1:
        ICheck_Balance obj = new ATM();
        obj.Check_Balance();
        break;
    case 2:
        IWithdraw_Cash obj_CashWithdrawl = new ATM();
        obj_CashWithdrawl.Withdraw_Cash();
        break;
    case 3:
        IDeposit_Amount obj_CashDeposit = new ATM();
        obj_CashDeposit.Deposit_Amount();
        break;
    case 4:
        IMini_Statement obj_MiniStatement = new ATM();
        obj_MiniStatement.Print_Mini_Statement();
        break;
    case 5:
        IChange_Pin obj_Change_Pin = new ATM();
        obj_Change_Pin.Change_Pin();
        break;
    default:
        Console.WriteLine("Invalid Entry..");
        break;
}