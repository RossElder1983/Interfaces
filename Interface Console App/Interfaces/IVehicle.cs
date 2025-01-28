using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsoleApp.Interfaces
{
    internal interface IVehicle
    {
        string colour { get; }
        string name { get; }
        string description { get; }

        void StartEngine();
        void StopEngine();
    }
}
