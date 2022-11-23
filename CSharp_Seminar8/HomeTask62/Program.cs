// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Zapolnenie(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = 0;
        }
    }
    Console.WriteLine("Введите любое положительное число, с которого будет начинаться спираль:");
    int s = Convert.ToInt32(Console.ReadLine());
    int nachalo = s;
    for (int i = 0; i < 4; i++)
    {
        array[0, i] = s;
        s++;
    }
    for (int i = 1; i < 4; i++)
    {
        array[i, 3] = s;
        s++;
    }
    for (int i = 2; i >= 0; i--)
    {
        array[3, i] = s;
        s++;
    }
    for (int i = 2; i > 0; i--)
    {
        array[i, 0] = s;
        s++;
    }

    //Периметр заполнен. Продолжаем заполнять массив и задаём
    //координаты ячейки, которую необходимо заполнить следующей.
    int a = 1;
    int b = 1;

    while (s < (nachalo + 15))
    {
        //В Java инициализированный интовый массив заполняется нулями.
        //Периметр мы заполнили числами, отличными от нулей.
        //Следующие циклы поочерёдно работают, заполняя ячейки.
        //Вложенный цикл останавливается, если следующая ячейка имеет 
        //значение, отличное от ноля. Ячейка, на которой остановился 
        //цикл, не заполняется.

        //Движемся вправо.
        while (array[a, b + 1] == 0)
        {
            array[a, b] = s;
            s++;
            b++;
        }

        //Движемся вниз.
        while (array[a + 1, b] == 0)
        {
            array[a, b] = s;
            s++;
            a++;
        }

        //Движемся влево.
        while (array[a, b - 1] == 0)
        {
            array[a, b] = s;
            s++;
            b--;
        }

        //Движемся вверх.
        while (array[a - 1, b] == 0)
        {
            array[a, b] = s;
            s++;
            a--;
        }
    }

    //При данном решении в центре всегда остаётся незаполненная ячейка.
    //Убираем её при помощи следующего цикла.
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = s;
            }
        }
    }
    return (array);
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

int[,] array = new int[4, 4];
array = Zapolnenie(array);
Vyivod(array);