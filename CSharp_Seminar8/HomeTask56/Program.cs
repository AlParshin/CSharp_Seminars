// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Zapolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 100));
        }
    }
    return array;
}

void Vyivod(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вот такой симпатичный массивчик у нас получился:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "     ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int Summa(int[,] array)
{
    int[] sum = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i, j];
        }
    }
    Console.WriteLine("Покажем полученные суммы элементов в каждой строке:");
    Console.Write("[");
    for (int k = 0; k < sum.Length; k++)
    {
        if (k == 0)
        {
            Console.Write(sum[k]);
        }
        else
        {
            Console.Write($",     {sum[k]}");
        }
    }
    Console.Write("]");
    Console.WriteLine("");
    Console.WriteLine("");
    int min = sum[0];
    int minl = 0;
    for (int l = 1; l < sum.Length; l++)
    {
        if (min > sum[l])
        {
            min = sum[l];
            minl = l;
        }
    }
    return minl;
}

int[,] array = new int[10, 10];

array = Zapolnenie(array);
Vyivod(array);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine($"Строка с минимальной суммой элементов - это строка с индексом: {Summa(array)}");