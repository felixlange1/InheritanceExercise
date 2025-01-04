using System;

namespace Inheritance;

public class Bird : Animal
{
    public double Speed { get; set; }
    public double WingSpan { get; set; }
    public bool Migratory { get; set; }

    public void Fly()
    {
        Console.WriteLine($"I'm flying at {Speed}");
    }
}