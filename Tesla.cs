using Garage;
public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"{MainColor} zip you.......zzzzzzzzzzzrooom!");
    }

     public virtual void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Tesla carefully turns {direction}");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla rolls to a stop");
    }
}