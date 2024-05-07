namespace Garage;

public class Cessna:Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }

     public override void Drive()
    {
        Console.WriteLine($"{MainColor} blaze ......doooodoooodoooodoooooooo!");
    }

     public virtual void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Cessna carefully turns {direction}");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna rolls to a stop");
    }
}