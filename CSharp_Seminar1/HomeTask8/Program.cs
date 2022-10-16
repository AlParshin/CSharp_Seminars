// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n;

n = 1;
if (n1 < 0)
{
    Console.WriteLine($"Наше число {n1} отрицательное и не соответствует условиям поставленной задачи :-(");
}
else if (n1 == 0)
{
    Console.WriteLine($"Наше число {n1} четное, но по условию задачи нам нужны только четные числа от 1 :-(");
}
else if (n1 == 1)
{
    Console.WriteLine($"Четных чисел при входном значении числа = {n1} нет :-(");
}
else
{
    Console.WriteLine($"Наши четные числа от 1 до {n1}:");
    while (n <= n1)
    {
        if (n % 2 == 0)
        {
            Console.Write(n);
            Console.Write(" ");
        }
        n++;
    }
}