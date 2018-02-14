using System;

public class Car : CarAbstract, ICar {
    //Fields or Properties
    public string Model { get; set; }
    public CarSpecs carSpecs { get; set; }
    private CarComponents carComponents { get; set; }
    private string _color;
    public long innerCarSales = 0;
    public static long CarSales = 0;

    //Default Constructor
    public Car() {
        //Console.WriteLine("Car()");
        this.Model = "Nissan Tsuru";
        this.Color = "Green";
        carComponents = new CarComponents();
        carComponents.NumberOfWheels = 4;
        carComponents.DashboardColor = "Black";
        carSpecs = new CarSpecs();
        carSpecs.MaxPower = "300 HP";
        innerCarSales++;
        CarSales++;
    }

    public Car(string model) {
        //Console.WriteLine("Car(string model)");
        this.Model = model;
        this.Color = "Green";
        innerCarSales++;
        CarSales++;
    }

    public Car(string model, string color) {
        //Console.WriteLine("Car(string model, string color)");
        this.Model = model;
        this.Color = color;
        innerCarSales++;
        CarSales++;
    }

    public string Color {
        get { return _color; }//getter
        set { _color = value; }//setter
    }
    //Signature

    public virtual void Drive() {
        Console.WriteLine("Driving in my car...");
    }

    public void TurnOn() {
        Console.WriteLine("Run...");
    }
    public void TurnOn(string sound) {
        Console.WriteLine("Run... " + sound);
    }
    public void TurnOn(int times) {
        for(int i = 0; i < times; i++) {
            Console.WriteLine("Run...");
        }
    }
    public void TurnOn(string sound, int times) {
        for(int i = 0; i < times; i++) {
            Console.WriteLine("Run... " + sound);
        }
    }

    private class CarComponents {
        public int NumberOfWheels { get; set; }
        public string DashboardColor { get; set; }
    }

    public class CarSpecs {
        public string MaxPower { get; set; }
    }

    public override string GetDetails() {
        string details = base.GetDetails();
        details += $", Model: {Model}, Color:{Color}";
        return details;
    }

}