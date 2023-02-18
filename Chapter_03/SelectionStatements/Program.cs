using static System.Console;

#region 

string password = "ninja";
if (password.Length < 8)
{
 WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
 WriteLine("Your password is strong.");
}

#endregion

#region 

// добавьте или удалите "", чтобы изменить поведение
object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} * {j} = {i * j}");
}
else
{
    WriteLine($"o is not an int so it cannot multiply");
}

#endregion

#region 

int number = (new Random()).Next(1, 7);
WriteLine($"My random number is {number}");
switch (number)
{
    case 1:
        WriteLine("One");
        break; // переход в конец оператора switch
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // блок, содержащий несколько случаев
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // конец оператора switch
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

#endregion

#region 

string path = @"E:\learning\markjprice_cs10dotnet6\Chapter_03";
Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
Stream? s;
if (key.Key == ConsoleKey.R)
{
    s = File.Open(Path.Combine(path, "file.txt"),
                        FileMode.OpenOrCreate,
                        FileAccess.Read);
    
}
else
{
    s = File.Open(Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write);
}
string message;
switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        message = "The stream is a memory address.";
        break;
    default: // всегда выполняется последним, несмотря на текущее положение
        message = "The stream is some other type.";
        break;
    case null:
        message = "The stream is null.";
        break;
}
WriteLine(message);

#endregion