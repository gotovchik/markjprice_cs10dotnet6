using System;


#region // неявное приведение типов

int a = 10;
double b = a; // неявное безопасное преведение int к double 
Console.WriteLine(b);

double c = 9.8;
// int d = c; // error CS0266 ( нельзя привести неявно double к int, т.к. это потенциально небезопасно: может привести к потери данных)
int d = (int)c; // явное приведение к типу int.  d == 9, потеря не целой части! 

#endregion

#region // явное приведение типов

long e = 10;
int f = (int)e;
Console.WriteLine($"e is {e:N0} and f is {f:N0}"); // будет работать так как значение не слишком больше для int
e = long.MaxValue;
f = (int)e;
Console.WriteLine($"e is {e:N0} and f is {f:N0}"); // будет работать отображая некорректное поведение, так как слишком большое значение для int

#endregion

#region // класс Convert

double g = 9.8;
int h = Convert.ToInt32(g);
Console.WriteLine($"g is {g} and h is {h}"); // h == 10; при методе ToInt32 идет округление числа, а не отбрасывание дробной части

double[] doubles = new[] {9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

foreach (double n in doubles)
{
    Console.WriteLine($"ToInt32({n}) == {Convert.ToInt32(n)}");
}

/*
ToInt32(9,49) == 9                  число всегда округляется в меньшую сторону, если десятичная часть меньше 0,5
ToInt32(9,5) == 10                  
ToInt32(9,51) == 10                 число всегда округляется в большую сторону, если десятичная часть больше 0,5
ToInt32(10,49) == 10                
ToInt32(10,5) == 10                 число округляется в большую сторону, если десятичная часть равна 0,5, а целая 
ToInt32(10,51) == 11                часть — нечетная, и округляется в меньшую сторону, если целая часть — четная.
*/

#endregion

#region // преобразование бинарного объекта в строку

byte[] binaryObject = new byte[128];
Random random = new Random();
random.NextBytes(binaryObject);

Console.WriteLine("Binary Object as bytes:");

for(int i = 0; i < binaryObject.Length; i++)
{
    Console.Write($"{binaryObject[i]:X} ");
}
Console.WriteLine($"");

string encoded = Convert.ToBase64String(binaryObject);
Console.WriteLine($"Binaty Object as Base64: {encoded}");

#endregion

#region // Разбор строк для преобразования в числа или значения даты и времени (метод Parse)

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("18 May 1995");

Console.WriteLine($"I was born {age} years ago.");
Console.WriteLine($"My birthday is {birthday}.");
Console.WriteLine($"My birthday is {birthday:D}.");

Console.Write("How many apples are there? ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int count))
{
    Console.WriteLine($"There are {count} apples.");
}
else
{
    Console.WriteLine($"I Could not parse the input.");
}

#endregion