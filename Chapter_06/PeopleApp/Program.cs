using Packt.Shared;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

// call sample method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

// call static method
Person baby2 = Person.Procreate(harry, jill);

WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine(
    format: "{0}'s first child is named \"{1}\".",
    arg0: harry.Name,
    arg1: harry.Children[0].Name);

// call operator
Person baby3 = harry * mary;

// call method with local func
WriteLine($"5! is {Person.Factorial(5)}");

/*#region // delegate

// call method
Person p1 = new();
int answer = p1.MethodIWantToCall("Frog");

// delegate
delegate int DelegateWithMatchingSignature(string s);

// create delegate sample
DelegateWithMatchingSignature d = new(p1.MethodIWantToCall); // CS8803

// call delegate
int answer2 = d("Frog");

#endregion*/

// Definition and processing delegate
harry.Shout += Harry_Shout; // method in end of file
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

ReadKey();