// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int Chet(int[] array, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return (sum);
}

int size = new Random().Next(10, 100);
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(new Random().Next(-99, 100));
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
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {result}");