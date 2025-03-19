using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Computer
    {
        public string Processor { get; }
        public string Memory { get; }
        public string Storage { get; }
        public string? GraphicsCard { get; private set; }
        public string? PowerSupply { get; private set; }
        public string? CoolingSystem { get; private set; }
        public string? OperatingSystem { get; private set; }

        public Computer(string processor, string memory, string storage)
        {
            Processor = processor;
            Memory = memory;
            Storage = storage;
        }

        public class ComputerBuilder
        {
            private Computer computer;
            public ComputerBuilder(string processor, string memory, string storage)
            {
                computer = new Computer(processor, memory, storage);
            }
            public ComputerBuilder WithGraphicsCard(string graphicsCard)
            {
                computer.GraphicsCard = graphicsCard;
                return this;
            }
            public ComputerBuilder WithPowerSupply(string powerSupply)
            {
                computer.PowerSupply = powerSupply;
                return this;
            }
            public ComputerBuilder WithCoolingSystem(string coolingSystem)
            {
                computer.CoolingSystem = coolingSystem;
                return this;
            }
            public ComputerBuilder WithOperatingSystem(string operatingSystem)
            {
                computer.OperatingSystem = operatingSystem;
                return this;
            }
            public Computer Build()
            {
                return computer;
            }
        }
    }
}
