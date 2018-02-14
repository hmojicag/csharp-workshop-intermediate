using System;

public class CarSport : Car {
    public string TurboType { get; set; }
    public CarSport() {

    }

    public override string GetDetails() {
        string details = base.GetDetails();
        details += $", TurboType: {TurboType}";
        return details;
    }

    public override void Drive() {
        Console.WriteLine("Driving my sport car....");
    }

}