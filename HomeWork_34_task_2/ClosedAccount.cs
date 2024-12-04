namespace HomeWork_34;

public class ClosedAccount : Account
{
    public ClosedAccount(int accountNumber, decimal balance) 
        : base(accountNumber, balance) { }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Закрытый счет #{AccountNumber}: Баланс {Balance:C}");
    }
}