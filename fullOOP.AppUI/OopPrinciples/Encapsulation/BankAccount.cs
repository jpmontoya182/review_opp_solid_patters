
namespace fullOOP.AppUI.OopPrinciples.Encapsulation;

public class BankAccount
{
    private decimal _balance;
    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit Amount must be positive");
        }

        _balance += amount;
    }

    public void WithDraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrwal amount must be positive");
        }

        if (amount > _balance)
        {
            throw new InvalidOperationException("Insuffucient funds");
        }

        _balance -= amount;
    }

    public decimal GetBalance() => _balance;
    
}
