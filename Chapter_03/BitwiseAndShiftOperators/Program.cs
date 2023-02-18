using static System.Console;

#region 

int a = 10; // 00001010
int b = 6; // 00000110
WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); // только столбец 2-го бита
WriteLine($"a | b = {a | b}"); // столбцы 8, 4 и 2-го битов
WriteLine($"a ^ b = {a ^ b}"); // столбцы 8 и 4-го битов
WriteLine();
// 01010000 — сдвиг влево переменной а на три битовых столбца
WriteLine($"a << 3 = {a << 3}");
// умножение переменной a на 8
WriteLine($"a * 8 = {a * 8}");
// 00000011 сдвиг вправо переменной b на один битовый столбец
WriteLine($"b >> 1 = {b >> 1}");

#endregion

#region 

WriteLine();
WriteLine("Outputting integers as binary:");
WriteLine($"a = {ToBinaryString(a)}");
WriteLine($"b = {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

static string ToBinaryString(int value)
{
 return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}

#endregion

