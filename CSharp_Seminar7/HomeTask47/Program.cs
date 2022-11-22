// Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
// Округлите значения, генерируемые Random до двух знаков после запятой.

double[,] Zapolnenie(double[,] array)
{
    double temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = new Random().NextDouble();
            array[i, j] = Math.Round(temp, 2, MidpointRounding.AwayFromZero);
        }
    }
    return array;
}

void Vyivod(double[,] array)
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

Console.WriteLine("Введите количество строк двумерного массива M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива N:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

array = Zapolnenie(array);
Vyivod(array);