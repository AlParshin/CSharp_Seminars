// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void Rekursiya(int N)
{
    Console.Write(N + " ");
    if (N == 1) return;
    Rekursiya(N - 1);
}

Console.WriteLine("Введите натуральное число N, чтобы оно было > 1 :");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Выведем все натуральные числа от {N} до 1:");
Rekursiya(N);