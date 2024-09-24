namespace fullOOP.AppUI.OopPrinciples.Coupling;

public class EmailSenderBad
{
    public void SendEmail(string message)
    {
        // Email sending logic 
        Console.WriteLine($"Sending Email : {message}");
    }
}
