
namespace fullOOP.AppUI.OopPrinciples.Abstraction;

public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        Disconnect();
        Console.WriteLine("The email was sent ...");
    }

    private void Disconnect()
    {
        Console.WriteLine("Disconneting ...");
    }

    private void Connect()
    {
        Console.WriteLine("Connecting ...");
    }

    private void Authenticate()
    {
        Console.WriteLine("authenticate in the server ...");

    }
}
