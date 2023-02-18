using static System.Console;

#region 

bool a = true;
bool b = false;
WriteLine($"AND | a | b ");
WriteLine($"a | {a & a,-5} | {a & b,-5} ");
WriteLine($"b | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR | a | b ");
WriteLine($"a | {a | a,-5} | {a | b,-5} ");
WriteLine($"b | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR | a | b ");
WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");

#endregion

#region

static bool DoStuff()
{
 WriteLine("I am doing some stuff.");
 return true;
}

WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}");
WriteLine();
WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStuff() = {b && DoStuff()}");

// функция работает, когда объединяется с переменной a,
// но не запускается в момент объединения с переменной b.
// Это связано с тем, что переменная b имеет значение
// false, поэтому в любом случае результат будет ложным, ввиду чего функция
// не выполняется
#endregion
