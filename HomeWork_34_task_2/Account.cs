namespace HomeWork_34;

public abstract class Account
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public Account(int accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public abstract void DisplayAccountInfo();
}