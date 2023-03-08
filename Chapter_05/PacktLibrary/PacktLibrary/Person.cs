using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public partial class Person
    {
        // Fields
        public string Name;
        public DateTime DateOfBirth;

        // Storage using the enum type
        public WondersOfTheAncientWorld FavoriteAncientWonder;

        // Storing multiple values using collections
        public List<Person> Children = new(); 

        public const string Species = "Homo Sapiens"; // const
        public readonly string HomePlanet = "Earth"; // readonly
        public readonly DateTime Instantiated;

        // Constructors
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // Methods
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit() // return tuple
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit() // named tuple
        {
            return (Name: "Apples", Number: 5);
        }

        // Deconstructors
        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }

        public void Deconstruct(out string name,
         out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateOfBirth;
            fav = FavoriteAncientWonder;
        }

        // Defining and passing parameters to methods
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        // Method overloading
        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        // Passing optional and named parameters
        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
        }

        // Parameter transmission control
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have default values
            // and must be initilized the method
            z = 99;

            // increase each parameter
            x++;
            y++;
            z++;
        }
    }
}
