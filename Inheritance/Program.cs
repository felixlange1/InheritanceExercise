using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */



            var parrot = new Bird() 
            {
                Species = "Macaw",
                Age = 12,
                Gender = "Female",
                Habitat = "Jungle",
                Speed = 12,
                Migratory = false,
                WingSpan = 45
            };
            Console.WriteLine($"Species: {parrot.Species}\nAge: {parrot.Age}\nGender: {parrot.Gender}\nHabitat: {parrot.Habitat}\nSpeed: {parrot.Speed}\nMigratory: {parrot.Migratory}\nWingSpan: {parrot.WingSpan}");
            parrot.Fly();
            Console.WriteLine("--------------------------------------");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var lizard = new Reptile()
            {
                Species = "Lizard",
                Age = 4,
                Gender = "Male",
                Habitat = "Tropics",
                IsVenomous = false,
                PreferredTemperature = 89,
            };
            Console.WriteLine($"Species: {lizard.Species}\nAge: {lizard.Age}\nGender: {lizard.Gender}\nHabitat: {lizard.Habitat}\nVenomous: {lizard.IsVenomous}\nPreferredTemperature: {lizard.PreferredTemperature}");
            lizard.Crawl();
            lizard.BaskInSun();
            
        }
    }
}
