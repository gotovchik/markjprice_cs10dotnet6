namespace Packt.Shared;

// Only for initialization properties
public class ImmutablePerson
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

// Records
public record ImmutableVehicle
{ 
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; }
}

// Simplifying syntax and auto generation records

/*
 * public record ImmutableAnimal
 * {
 *     public string Name { get; init; }
 *     public string Species { get; init; }
 *     public ImmutableAnimal(string name, string species)
 *     {
 *         Name = name;    
 *         Species = species;
 *     }
 *     public void Deconstruct(out string name, out string species)
 *     {
 *         name = Name; species = Species;
 *     }
 * }
 */

public record ImmutableAnimal(string Name, string Species);


