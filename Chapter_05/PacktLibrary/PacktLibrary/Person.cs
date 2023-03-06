using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person
    {
        // Поля
        public string Name;
        public DateTime DateOfBirth;

        // Хранение с помощью типа enum
        public WondersOfTheAncientWorld FavoriteAncientWonder;

        // Хранение нескольких значений с помощью коллекций
        public List<Person> Children = new(); 

        public const string Species = "Homo Sapiens"; // константа
        public readonly string HomePlanet = "Earth"; // только для чтения
        public readonly DateTime Instantiated;

        // Конструкторы
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

        // Методы
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit() // возвращает кортеж
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit() // именованый кортеж
        {
            return (Name: "Apples", Number: 5);
        }

        // Деконструкторы
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

        // Определение и передача параметров в методы
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        // Перегрузка методов
        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        // Передача необязательных и именованных параметров
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
