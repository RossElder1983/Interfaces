using InterfaceConsoleApp.Concrete;
using InterfaceConsoleApp.Interfaces;
using System.Diagnostics;

Console.WriteLine("Starting vehicle creation");

IVehicle car = new Car("Red", "Ferarri", "F40 LM");

IVehicle truck = new Truck("Blue", "Iveco", "Bin lorry");

List<IVehicle> vehicles = new List<IVehicle>();
vehicles.Add(car);
vehicles.Add(truck);

foreach (var vehicle in vehicles)
    vehicle.StartEngine();

foreach (var vehicle in vehicles)
    vehicle.StopEngine();
