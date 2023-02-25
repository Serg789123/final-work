// Программа, которая из имеющегося массива строк формирует массив из строк 
// длина которых не превышает 3 символов

string[] arr = new string[4];

for (int i = 0; i < 4; i++)
{
    Console.Write($"Введиде несколько символов без пробелов под индексом {i}: ");
    arr[i] = Console.ReadLine();
}
Console.WriteLine();
Console.Write("[ ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}, ");
}
Console.Write("\b\b ");
Console.Write("] -> [  ");

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 4)
    {
        Console.Write($"{arr[i]}, ");
    }
}
Console.Write("\b\b ");
Console.WriteLine("]");
Console.WriteLine();
