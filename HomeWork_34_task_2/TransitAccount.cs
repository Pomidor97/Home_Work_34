using HomeWork_34;

namespace Lesson_33;

public class TransitAccount : Account
{
    public TransitAccount(int accountNumber, decimal balance) 
        : base(accountNumber, balance) { }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Транзитный счет #{AccountNumber}: Баланс {Balance:C}");
    }
}