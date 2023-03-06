using Packt.Shared;
using System;

# region // Работа с объектами

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);

Console.WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

Console.WriteLine(format: "{0} was born on {1:dd MMM yy}",
 arg0: alice.Name,
 arg1: alice.DateOfBirth);

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });
Console.WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach(Person person in bob.Children)
{
    Console.WriteLine($" {person.Name}");
}

#endregion

#region // Создание статического поля

BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

Console.WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

Console.WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

#endregion

#region
// константы
Console.WriteLine($"{bob.Name} is a {Person.Species}");

// readonly
Console.WriteLine($"{bob.Name} was born on {bob.HomePlanet}");


#endregion

#region // конструкторы

Person blankPerson = new();

Console.WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

Console.WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);


#endregion

#region // методы

bob.WriteToConsole();
Console.WriteLine(bob.GetOrigin());

// кортежи
(string, int) fruit = bob.GetFruit();
Console.WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

// именованный кортеж
var fruitNamed = bob.GetNamedFruit();
Console.WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}" );

// автоматическое именование членов кортежа
var thing1 = ("Neville", 4);
Console.WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
Console.WriteLine($"{thing2.Name} has {thing2.Count} children.");



#endregion

#region //деконструкторы

(string fruitName, int fruitNumber) = bob.GetFruit(); // деконструкция кортежа
Console.WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");



#endregion

Console.ReadKey();
