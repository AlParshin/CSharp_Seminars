// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"Наибольшее число = {n1}, а наименьшее число = {n2}");
}
else if (n1 < n2)
{
    Console.WriteLine($"Наибольшее число = {n2}, а наименьшее число = {n1}");
}
else
{
    Console.WriteLine($"Наши числа {n2} и {n1} равны между собой");
}