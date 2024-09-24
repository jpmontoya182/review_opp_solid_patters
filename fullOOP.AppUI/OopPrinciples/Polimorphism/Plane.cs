namespace fullOOP.AppUI.OopPrinciples.Polimorphism;

public class Plane: Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Plane is starting");
    }

    public override void Stop()
    {
        Console.WriteLine("Plane is stopping");
    }
}
