using InterfaceConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsoleApp.Concrete
{
    internal class Truck : IVehicle
    {
        //Properties
        public string colour { get; }
        public string name { get; }
        public string description { get; }
        public bool hasTipper { get; }

        //Constructors
        public Truck(string colour, string name, string description)
        {
            this.colour = colour;
            this.description = description;
            this.name = name;
        }

        //Methods
        public void StartEngine()
        {
            Console.WriteLine($"The {this.colour} truck called {this.name}, that looks like {this.description}, has started.");
        }

        public void StopEngine()
        {
            Console.WriteLine($"The {this.colour} truck called {this.name}, that looks like {this.description}, has stopped.");
        }
    }
}
