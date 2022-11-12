// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.

int[] array = new int[8];
Console.WriteLine("Ввведите 8 элементов массива:");
for (int i = 0; i < 8; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("А теперь давайте посмотрим на введенные нами элементы:");
Console.Write("[");
for (int i = 0; i < 8; i++)
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