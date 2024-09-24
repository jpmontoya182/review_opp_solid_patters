namespace fullOOP.AppUI.OopPrinciples.Coupling;

internal class OrderBad
{
    public void PlaceOrder()
    {
        // place order logic
        EmailSenderBad emailSender = new();

        // in this case we are very coupled to the email class 

        emailSender.SendEmail("Order placed successfully");

        Console.WriteLine("");
    }
}
