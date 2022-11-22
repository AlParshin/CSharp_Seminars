// Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для поиска ср. арифметического значения каждого столбца.

int[,] Zapolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 1000));
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

double[] Arifmetika(int[,] array, double[] sum)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum[j] = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[j] = sum[j] + array[i, j];
        }
        sum[j] = sum[j] / array.GetLength(0);
    }
    return sum;
}

Console.WriteLine("Введите количество строк двумерного массива M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива N:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
double[] sum = new double[n];

array = Zapolnenie(array);
Vyivod(array);
sum = Arifmetika(array, sum);
Console.WriteLine("Средние арифметические суммы элементов каждого столбца:");
Console.Write("[");
for (int i = 0; i < n; i++)
{
    if (i == 0)
    {
        Console.Write(sum[i]);
    }
    else
    {
        Console.Write($",     {sum[i]}");
    }
}
Console.Write("]");