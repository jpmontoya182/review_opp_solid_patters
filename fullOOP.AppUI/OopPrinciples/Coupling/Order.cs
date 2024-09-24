namespace fullOOP.AppUI.OopPrinciples.Coupling;

public class Order
{
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    public void PlaceOrder()
    { 
        // order place logic
        this.notificationService.SendNotification("Order placed successfully");

        Console.WriteLine("");
    }
}
