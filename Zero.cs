namespace Garage;

public class Zero:Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    
    public void ChargeBattery()
    {
        // method definition omitted
    }
     public override void Drive()
    {
        Console.WriteLine($"{MainColor} zero .... kikikikikikiiom!");
    }

     public virtual void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Zero carefully turns {direction}");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero rolls to a stop");
    }
}