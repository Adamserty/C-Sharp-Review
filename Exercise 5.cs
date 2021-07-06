using System;

class Paints
{
    string color = "red";
    static void Main(string[] args)
    {
        Paints myObj1 = new Paints();
        Paints myObj2 = new Paints();
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj2.color);
    }
}