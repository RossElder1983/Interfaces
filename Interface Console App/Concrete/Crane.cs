using InterfaceConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_console_app.Concrete
{
    internal class Crane : IVehicle
    {
        public string colour => throw new NotImplementedException();

        public string name => throw new NotImplementedException();

        public string description => throw new NotImplementedException();

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
