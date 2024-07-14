// this shows uses of classes and structs as well as local methods and readonly fields

using System;

class Program
{
    void WriteCubes()
    {
        int WriteCubes(int value) => value * value * value;
        Console.WriteLine(3);
        Console.WriteLine(4);
        Console.WriteLine(5);
    }

    static void Main()
    {
        // Octopus class
        var octopus = new Octopus("Will");
        octopus.getOctopiInfo();

        //using the Car struct
        Car car = new Car("McLaren", "Senna");
        car.getCarInfo();

        // using Cubes function
        WriteCubes();
    }
}

public class Octopus
{
    string Name;
    public int Age = 10;
    public readonly int Tentacles = 8;

    // Constructor for adding name
    public Octopus(string name)
    {
        Name = name;
    }

    // Method for getting the octopus info
    public void getOctopiInfo()
    {
        Console.WriteLine($"This octupus is named {Name} and are {Age} months old and have {Tentacles} tentacles.");
    }
}

struct Car
{
    public readonly int Year = 2019;
    public string Make;
    public string Model;

    // constructor for new car fields
    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    // Method for car info
    public void getCarInfo()
    {
        Console.WriteLine($"The all-new {Year} {Make} {Model}!");
    }
}


