// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);
int second;

Console.WriteLine($"Наше случайное трехзначное число = {number}");
number = number / 10;
second = number % 10;

Console.WriteLine($"Вторая цифра в нашем трехзначном числе = {second}");