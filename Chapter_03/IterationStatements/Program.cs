using System;

#region // цикл while

int x = 0;
while (x < 10)
{
    Console.WriteLine(x);
    x++;
}

#endregion

#region // цикл do while

string? password;
int i = 0;

do
{
    Console.Write("Enter your password");
    password = Console.ReadLine();
    i++;
}
while (password != "12345678" && i < 10);
if (i < 10)
{
    Console.WriteLine("Correct");
}
else
{
    Console.WriteLine($"Incorrect password was entered 10 times");
}

#endregion

#region // цикл for

for (int j = 0; j < 10; j++)
{
    Console.WriteLine(j);
}

#endregion

#region // цикл foreach

string[] names = {"Igor", "Violetta", "Sofia"};
foreach (string name in names)
{
    Console.WriteLine(name);
}

/*
Технически оператор foreach будет работать с любым типом, соблюдающим правила, изложенные ниже.
1. Тип должен иметь метод GetEnumerator, который возвращает объект.
2. Возвращаемый объект должен иметь свойство Current и метод MoveNext.
3. Метод MoveNext должен изменять значение Current и возвращать значение
true, если есть другие элементы для перечисления, или значение false, если
элементов больше нет.
Существуют интерфейсы с именами IEnumerable и IEnumerable <T>, которые формально определяют эти правила, но технически компилятору не требуется тип для
реализации этих интерфейсов.
Компилятор превращает код оператора foreach из предыдущего примера в нечто
похожее на псевдокод, показанный ниже:
IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
 string name = (string)e.Current; // Current – только для чтения!
 WriteLine($"{name} has {name.Length} characters.");
}
Из-за применения итератора переменная, объявленная в операторе foreach, не может использоваться для изменения значения текущего элемента.

*/
#endregion