using System;

namespace session1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Model = "BMW X3";
            car.Color = "Blanco";
            car.carSpecs.MaxPower = "1,500 HP";
            car.SerialNumber = "123";

            Car anotherCar = new Car("Honda Civic");
            anotherCar.Color = "Dark Grey";
            anotherCar.SerialNumber = "987";

            Car yetAnotherCar = new Car("Chevrolet Camaro", "Yellow");
            yetAnotherCar.SerialNumber = "321";

            Car mercedez = new Car() {
                Model = "mercedez 200",
                Color = "Silver"
            };
            mercedez.carSpecs.MaxPower = "5,500HP";
            mercedez.SerialNumber = "765";

            var anonymousCar = new  {
                Model = "Anonymous Car",
                Color = "Red",
                MaxPower = "10,000HP",
                Year = "1990"
            };

            CarSport f1 = new CarSport();
            f1.Model = "F1";
            f1.Color = "Red";
            f1.carSpecs.MaxPower = "30 000HP";
            f1.TurboType = "Over Power Turbo";
            f1.SerialNumber = "456789";

            CarClassic T4 = new CarClassic() {
                Model = "Ford T4",
                Color = "Black",
                NumberInTheWorld = 10
            };
            
            /*Console.WriteLine($"car - {car.GetDetails()}");
            Console.WriteLine($"anotherCar - {anotherCar.GetDetails()}");
            Console.WriteLine($"yetAnotherCar - {yetAnotherCar.GetDetails()}");
            Console.WriteLine($"mercedez - {mercedez.GetDetails()}");
            Console.WriteLine($"f1 - {f1.GetDetails()}");
            Console.WriteLine($"T4 - {T4.GetDetails()}");*/
            /* 
            ICar[] cars = new ICar[5];
            cars[0] = car;
            cars[1] = anotherCar;
            cars[2] = anotherCar;
            cars[3] = f1;
            cars[4] = T4;

            foreach (ICar thisCar in cars) {
                thisCar.Drive();
            }*/

            Car[] carsAgain = new Car[5];
            carsAgain[0] = car;
            carsAgain[1] = anotherCar;
            carsAgain[2] = yetAnotherCar;
            carsAgain[3] = f1;
            carsAgain[4] = T4;

            foreach (Car thisCar in carsAgain) {
                Console.WriteLine(thisCar.GetDetails());
            }

        }
    }
}
