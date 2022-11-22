// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int Polozhitelnyie(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) j++;
    }
    return j;
}

void Pechat(int[] array)
{
    Console.WriteLine("А теперь давайте посмотрим на введенные нами элементы:");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write($", {array[i]}");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите количество чисел, которые будете вводить с клавиатуры:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Теперь введите эти числа через ENTER:");
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Pechat(array);
Console.WriteLine($"Количество чисел больше нуля среди введенных = {Polozhitelnyie(array)}");
