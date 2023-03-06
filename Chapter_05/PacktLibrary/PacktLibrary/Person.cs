using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person
    {
        // Ïîëÿ
        public string Name;
        public DateTime DateOfBirth;

        // Õðàíåíèå ñ ïîìîùüþ òèïà enum
        public WondersOfTheAncientWorld FavoriteAncientWonder;

        // Õðàíåíèå íåñêîëüêèõ çíà÷åíèé ñ ïîìîùüþ êîëëåêöèé
        public List<Person> Children = new(); 

        public const string Species = "Homo Sapiens"; // константа
        public readonly string HomePlanet = "Earth"; // òîëüêî äëÿ ÷òåíèÿ
        public readonly DateTime Instantiated;

        // Êîíñòðóêòîðû
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

        // Ìåòîäû
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit() // âîçâðàùàåò êîðòåæ
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit() // èìåíîâàíûé êîðòåæ
        {
            return (Name: "Apples", Number: 5);
        }

        // Äåêîíñòðóêòîðû
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

        // Îïðåäåëåíèå è ïåðåäà÷à ïàðàìåòðîâ â ìåòîäû
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        // Ïåðåãðóçêà ìåòîäîâ
        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        // Ïåðåäà÷à íåîáÿçàòåëüíûõ è èìåíîâàííûõ ïàðàìåòðîâ
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
    }
}
