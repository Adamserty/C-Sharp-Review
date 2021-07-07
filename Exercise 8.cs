using System;

class Car
{
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
        Car Chevrolet = new Car();
        Chevrolet.model = "Camaro";
        Chevrolet.color = "red";
        Chevrolet.year = 1969;

        Car Buick = new Car();
        Buick.model = "Encore";
        Buick.color = "white";
        Buick.year = 2005;

        Console.WriteLine(Chevrolet.model);
        Console.WriteLine(Buick.model);
    }
}