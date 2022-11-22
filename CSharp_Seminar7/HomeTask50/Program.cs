// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
// Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

int[,] Zapolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-999, 1000));
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

int[,] array = new int[10, 10];

array = Zapolnenie(array);
Vyivod(array);

Console.WriteLine("Введите номер строки искомого элемента, учитывая, что нумерация массива идет от нуля:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента, учитывая, что нумерация массива идет от нуля:");
int n = Convert.ToInt32(Console.ReadLine());
if (m > 9 || n > 9) Console.WriteLine("В массиве нет элемента с таким номером!!!");
else Console.WriteLine($"Наш искомый элемент = {array[m, n]}");