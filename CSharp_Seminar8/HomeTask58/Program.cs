// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.


int[,] Zapolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
    return array;
}

void Vyivod(int[,] array)
{
    Console.WriteLine();
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

int[,] Peremnozhenie(int[,] A, int[,] B, int[,] C)
{
    //A*B
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            C[i, j] = 0;
            for (int k = 0; k < B.GetLength(0); k++)
            {
                C[i, j] = C[i, j] + A[i, k] * B[k, j];
            }
        }
    }
    return C;
}

int[,] A = new int[2, 3];
int[,] B = new int[3, 2];
int[,] C = new int[A.GetLength(0), B.GetLength(1)];
A = Zapolnenie(A);
B = Zapolnenie(B);
Console.WriteLine("Массив A:");
Vyivod(A);
Console.WriteLine("Массив B:");
Vyivod(B);
C = Peremnozhenie(A, B, C);
Console.WriteLine("Результат умножения A на B:");
Vyivod(C);