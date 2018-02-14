using System;

public class CarClassic : Car {
    public int NumberInTheWorld { get; set; }
    public CarClassic() {

    }

    public override string GetDetails() {
        string details = base.GetDetails();
        details += $", NumberInTheWorld: {NumberInTheWorld}";
        return details;
    }

    public override void Drive() {
        Console.WriteLine("Driving my classic car....");
    }
}