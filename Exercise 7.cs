using System;

class CarSpeed
{
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
        CarSpeed myObj = new CarSpeed();
        myObj.fullThrottle();  // Call the method
    }
}