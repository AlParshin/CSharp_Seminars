// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры в числе нет.

long number = new Random().NextInt64(0, 9223372036854775807);

Console.WriteLine($"Наше случайное число = {number}");

if (number < 100)
{
    Console.WriteLine($"В нашем случайном числе {number} нет третьй цифры");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра в нашем числе = {number}");
}