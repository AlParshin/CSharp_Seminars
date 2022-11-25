// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Rekursiya(int M, int N, int sum)
{
    sum = sum + M;
    Console.Write(M + " ");
    if (M == N)
    {
        Console.WriteLine();
        return sum;
    }
    return Rekursiya(M + 1, N, sum);
}

Console.WriteLine("Введите натуральное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь введите натуральное N:");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N)
{
    int temp = N;
    N = M;
    M = temp;
}
int sum = 0;
Console.WriteLine("Натуральные элементы, которые находится в промежутке [M,N]:");
Console.WriteLine($"Сумма всех элементов в промежутке [M,N] равна {Rekursiya(M, N, sum)}");