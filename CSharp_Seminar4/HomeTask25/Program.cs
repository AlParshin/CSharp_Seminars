// Напишите программу, которая на вход принимает 2 числа (A и B) и возводит число A в натуральную степень B.

double Stepen(int A, int B)
{
    if (B == 0)
    {
        return (1);
    }
    else if (B < 0)
    {
        double res = A;
        for (int i = 1; i < Math.Abs(B); i++)
        {
            res = A * res;
        }
        return (1 / res);
    }
    else
    {
        int res = A;
        for (int i = 1; i < B; i++)
        {
            res = A * res;
        }
        return (res);
    }
}

Console.WriteLine("Введите число А, которое будем возводить в степень:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Теперь введите степень, в которую будем возводить наше число {A}:");
int B = Convert.ToInt32(Console.ReadLine());

double result = Stepen(A, B);
Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {result}");