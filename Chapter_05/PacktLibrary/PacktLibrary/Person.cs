using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person
    {
        // ����
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public List<Person> Children = new();
        public const string Species = "Homo Sapiens"; // ���������
        public readonly string HomePlanet = "Earth"; // ������ ��� ������
        public readonly DateTime Instantiated;

        // ������������
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

        // ������
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit() // ���������� ������
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit() //���������� ������
        {
            return (Name: "Apples", Number: 5);
        }
    }
}