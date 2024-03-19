// See https://aka.ms/new-console-template for more information
using Polymorphism_2.Abstract;
using Polymorphism_2.Models;


static void DisplayRentalRate(Vehicle vehicle)
{
    decimal rate = vehicle.CalcualateDailyRentalRate();
    Console.WriteLine($"Daily Rent Cost: {rate} $");
}

Car car = new Car { PassengerCapacity = 5 };

Truck truck = new Truck { LoadCapacity = 1000 };

DisplayRentalRate(car);
DisplayRentalRate(truck);