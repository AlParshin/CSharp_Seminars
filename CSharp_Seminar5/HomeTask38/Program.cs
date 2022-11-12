// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double Razn(double[] array, int size)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double raznitsa = max - min;
    return (raznitsa);
}

int size = new Random().Next(10, 20);
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble();
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
double result = Razn(array, size);
Console.WriteLine("");
Console.WriteLine($"Разница между максимальным и минимальным элекментом равна {result}");