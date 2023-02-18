using static System.Console;

#region // Унарные операции

int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");
WriteLine();

int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");
WriteLine();

#endregion

#region // Бинарные операции


int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
WriteLine();

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

#endregion

#region // Операции присваивания

int p = 6;
p += 3; // эквивалентно p = p + 3;
p -= 3; // эквивалентно p = p – 3;
p *= 3; // эквивалентно p = p * 3;
p /= 3; // эквивалентно p = p / 3;

#endregion