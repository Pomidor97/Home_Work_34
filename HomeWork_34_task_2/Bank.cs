namespace HomeWork_34;

public class Bank<T> where T : Account
{
    private List<T> accounts = new List<T>();

    public void AddAccount(T account)
    {
        accounts.Add(account);
    }

    public void DisplayAllAccounts()
    {
        foreach (var account in accounts)
        {
            account.DisplayAccountInfo();
        }
    }
}