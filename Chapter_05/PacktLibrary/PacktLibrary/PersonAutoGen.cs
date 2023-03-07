using System;

namespace Packt.Shared
{
    public partial class Person
    {
        // свойства
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{Name} says 'Hello!'";
        public public int Age => DateTime.Today.Year - DateOfBirth.Year;
    }
}

