using Packt.Shared;
using System;

# region // Objects

// Fields
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

// Storing multiple values using collections

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });
Console.WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach(Person person in bob.Children)
{
    Console.WriteLine($" {person.Name}");
}

#endregion

#region // Creating a static field

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

#region // Constants and readonly variables
// constants
Console.WriteLine($"{bob.Name} is a {Person.Species}");

// readonly
Console.WriteLine($"{bob.Name} was born on {bob.HomePlanet}");


#endregion

#region // Constructors

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

#region // Methods

bob.WriteToConsole();
Console.WriteLine(bob.GetOrigin());

// tuples
(string, int) fruit = bob.GetFruit();
Console.WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

// named tuple
var fruitNamed = bob.GetNamedFruit();
Console.WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}" );

// automatic naming of tuple members
var thing1 = ("Neville", 4);
Console.WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
Console.WriteLine($"{thing2.Name} has {thing2.Count} children.");



#endregion

#region // Deconstructors 

// deconstraction a tuple
(string fruitName, int fruitNumber) = bob.GetFruit(); 
Console.WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

// deconstraction an object 
var (name1, dob1) = bob;
Console.WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
Console.WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

#endregion

#region // Defining and passing parameters to methods

Console.WriteLine(bob.SayHello());

// Overload 
Console.WriteLine(bob.SayHello("Emily"));

// Passing optional and named parameters
Console.WriteLine(bob.OptionalParameters());
Console.WriteLine(bob.OptionalParameters("Jump!", 98.5));
Console.WriteLine(bob.OptionalParameters("Poke!", active: false));


#endregion

#region // Parameter transmission control 

int a = 10;
int b = 20;
int c = 30;

Console.WriteLine($"Before: a = {a}, b {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
Console.WriteLine($"After: a = {a}, b {b}, c = {c}");

#endregion

#region // Properties

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1972, 1, 27)
};

Console.WriteLine(sam.Origin);
Console.WriteLine(sam.Greeting);
Console.WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
Console.WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

sam.FavoritePrimatyColor = "Red";
Console.WriteLine($"Sam's favorite primary color is {sam.FavoritePrimatyColor}.");

#endregion

#region // Indexers 

sam.Children.Add( new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });
Console.WriteLine($"Sam's first child is {sam.Children[0].Name}");
Console.WriteLine($"Sam's second child is {sam[1].Name}");

#endregion

#region // Pattern matching using objects

object[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419 },
    new FirstClassPassenger { AirMiles = 16_562 },
    new BusinessClassPassenger(),
    new CoachClassPassenger { CattyOnKG = 25.7 },
    new CoachClassPassenger { CattyOnKG = 0 },
};

foreach (object passenger in passengers)
{

    /* C# 8
     * decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000m,
        CoachClassPassenger p when p.CattyOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };*/

    // C# 9 and later
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
        },
        BusinessClassPassenger                        => 1000M,
        CoachClassPassenger p when p.CattyOnKG < 10.0 => 500M,
        CoachClassPassenger                           => 650M,
        _                                             => 800M
    };

    Console.WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

#endregion

