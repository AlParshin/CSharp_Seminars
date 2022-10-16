//Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
int max;

if (n2 >= n1)
{
    max = n2;
}
else
{
    max = n1;
}
if (n3 >= max)
{
    max = n3;
}
Console.WriteLine($"Максимальное число из трех равно {max}");