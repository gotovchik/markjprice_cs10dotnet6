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
        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        public string FavoriteIceCream { get; set; }

        private string favoritePrimaryColor;

        public string FavoritePrimatyColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower()) {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primaty color. " +
                            "Choose from: red, green, blue");
                }
            }
        }
    }
}

