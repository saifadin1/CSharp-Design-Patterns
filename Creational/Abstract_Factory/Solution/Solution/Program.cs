using Solution.Factories;
using Solution.Products.Cars;
using Solution.Products.Trucks;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vehicle Manufacturing System!");
            Console.WriteLine("--------------------------------------------");

            while (true)
            {
                Console.WriteLine("\nChoose a brand:");
                Console.WriteLine("1. Tesla");
                Console.WriteLine("2. Ford");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                string brandChoice = Console.ReadLine();

                IVehicleFactory factory = null;

                switch (brandChoice)
                {
                    case "1":
                        factory = new TeslaFactory();
                        Console.WriteLine("\nYou selected Tesla.");
                        break;
                    case "2":
                        factory = new FordFactory();
                        Console.WriteLine("\nYou selected Ford.");
                        break;
                    case "3":
                        Console.WriteLine("\nExiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        continue;
                }

                Console.WriteLine("\nChoose a vehicle type:");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Truck");
                Console.WriteLine("3. Go back to brand selection");
                Console.Write("Enter your choice (1-3): ");
                string vehicleChoice = Console.ReadLine();

                switch (vehicleChoice)
                {
                    case "1":
                        ICar car = factory.CreateCar();
                        car.Drive();
                        break;
                    case "2":
                        ITruck truck = factory.CreateTruck();
                        truck.Haul();
                        break;
                    case "3":
                        continue;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
