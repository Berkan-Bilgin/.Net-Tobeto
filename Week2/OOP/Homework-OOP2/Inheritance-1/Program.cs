// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Car myCar = new Car { Brand = "Toyota", PassangerCapacity = 5 };

myCar.StartEngine();
Console.WriteLine(myCar.Brand);
Console.WriteLine(myCar.PassangerCapacity);


public class Vehicle
{
    public string Brand { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Started Engine.");
    }

}

public class Car : Vehicle
{
    public int PassangerCapacity { get; set; }
}



