using System;

namespace Inheritance;

public class Reptile : Animal
{
    public bool IsVenomous { get; set; }
    public double PreferredTemperature { get; set; }

    public void Crawl()
    {
        Console.WriteLine("I'm a reptile that can crawl.");
    }

    public void BaskInSun()
    {
        Console.WriteLine("I love sun!");
    }
}