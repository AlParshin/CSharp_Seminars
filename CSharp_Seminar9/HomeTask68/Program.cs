// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Функция Аккермана определяется рекурсивно для неотрицательных целых чисел m и n следующим образом
// A(m,n) = n + 1, если m = 0;
// A(m,n) = A(m-1, 1), если m > 0, n = 0;
// A(m,n) = A(m-1, A(m,n-1)), если m > 0, n > 0.

uint A(uint M, uint N)
{
    if (M == 0)
        return N + 1;
    else if ((M > 0) && (N == 0))
        return A(M - 1, 1);
    else //if (M > 0 && N > 0)
        return A(M - 1, A(M, N - 1));
}

Console.WriteLine("Введите натуральное число M:");
uint M = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Теперь введите натуральное N:");
uint N = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine($"Результат вычисления нашей функции Аккермана при M = {M} и N = {N} равен {A(M, N)}");