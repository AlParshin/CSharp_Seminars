// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummaZifr(int A)
{
    string strNum = Math.Abs(A).ToString();
    int length = strNum.Length;
    int[] array = new int[length];

    int i = length - 1;
    while (A != 0)
    {
        array[i] = A % 10;
        A = A / 10;
        i = i - 1;
    }

    int sum = 0;
    for (i = 0; i < length; i++)
    {
        sum = array[i] + sum;
    }
    return (Math.Abs(sum));
}

Console.WriteLine("Введите любое число:");
int A = Convert.ToInt32(Console.ReadLine());

int res = SummaZifr(A);
Console.WriteLine($"Сумма цифр в нашем числе {A} равна {res}");