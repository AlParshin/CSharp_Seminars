// Напишите программу, которая на вход принимает число (N) и выдает таблицу кубов чисел от 1 до N.

void PrintCube(int N)
{
    Console.WriteLine($"Кубы чисел от 1 до {N}:");
    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

Console.WriteLine("Введите N (>1):");
PrintCube(Convert.ToInt32(Console.ReadLine()));