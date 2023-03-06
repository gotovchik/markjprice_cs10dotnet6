using Packt.Shared;
using System;

# region // Работа с объектами

// Определение полей
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

// Хранение нескольких значений с помощью коллекций

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

#region // Константы и readonly переменные
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

// деконструкция кортежа
(string fruitName, int fruitNumber) = bob.GetFruit(); 
Console.WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

// деконструкция Person
var (name1, dob1) = bob;
Console.WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
Console.WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

#endregion

#region // Определение и передача параметров в методы

Console.WriteLine(bob.SayHello());

// Перегрузка 
Console.WriteLine(bob.SayHello("Emily"));

// Передача необязательных и именованных параметров
Console.WriteLine(bob.OptionalParameters());
Console.WriteLine(bob.OptionalParameters("Jump!", 98.5));
Console.WriteLine(bob.OptionalParameters("Poke!", active: false));


#endregion

#region // Управление передачей параметров

int a = 10;
int b = 20;
int c = 30;

Console.WriteLine($"Before: a = {a}, b {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
Console.WriteLine($"After: a = {a}, b {b}, c = {c}");



#endregion

Console.ReadKey();
