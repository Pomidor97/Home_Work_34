namespace HomeWork_34;

public class DepositAccount : Account
{
    public DepositAccount(int accountNumber, decimal balance) 
        : base(accountNumber, balance) { }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Депозитный счет #{AccountNumber}: Баланс {Balance:C}");
    }
}