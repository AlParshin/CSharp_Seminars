// Напишите программу, которая принимает на вход пятизначное число и определяет, является ли оно палиндромом.

bool Palindrom(int chislo)
{
    int[] array = new int[5];
    int i = 4;
    while (chislo != 0)
    {
        array[i] = chislo % 10;
        chislo = chislo / 10;
        i = i - 1;
    }
    if ((array[0] == array[4]) && (array[1] == array[3]))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int chislo = new Random().Next(10000, 100000);
bool res;

res = Palindrom(chislo);
if (res == true)
{
    Console.WriteLine($"Наше число {chislo} является палиндромом");
}
else
{
    Console.WriteLine($"Наше число {chislo} не является палиндромом");
}