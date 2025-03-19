using static Solution.Computer;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamingPC = new ComputerBuilder("Intel Core i9", "32", "1000")
                .WithGraphicsCard("Nvidia RTX 4090")
                .WithPowerSupply("1000W")
                .WithCoolingSystem("Water")
                .WithOperatingSystem("Windows 11")
                .Build();

            var officePC = new ComputerBuilder("Intel Core i5", "16", "500")
                .WithOperatingSystem("Windows 10")
                .Build();
        }
    }
}
