// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int Chet(int[] array, int size)
{
    int kol = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            kol = kol + 1;
        }
    }
    return (kol);
}

int size = new Random().Next(10, 100);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(new Random().Next(100, 1000));
}
Console.WriteLine("Рандомный массив получился вот таким:");
Console.Write("[");
for (int i = 0; i < size; i++)
{
    if (i == 0)
    {
        Console.Write(array[i]);
    }
    else
    {
        Console.Write($", {array[i]}");
    }
}
Console.Write("]");
int result = Chet(array, size);
Console.WriteLine("");
Console.WriteLine($"В нашем рандомном массиве количество четных числе равняется {result}");