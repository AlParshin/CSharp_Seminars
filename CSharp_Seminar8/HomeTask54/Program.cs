// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] Sortirovka(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] array = new int[10, 10];

array = Zapolnenie(array);
Vyivod(array);
array = Sortirovka(array);
Vyivod(array);