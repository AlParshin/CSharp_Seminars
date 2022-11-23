// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,,] Zapolnenie(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = Convert.ToInt32(new Random().Next(10, 100));
            }
        }
    }
    return array;
}

void Vyivod(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент {array[i, j, k]} расположен на позиции: ({i}, {j}, {k})");
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];
array = Zapolnenie(array);
Console.WriteLine("Наш заполненный массив:");
Vyivod(array);