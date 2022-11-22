// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Reshenie(float b1, float k1, float b2, float k2)
{
    // Вставляем значение y из первого уравнения во второе, получая k1 * x + b1 = k2 * x + b2

    // Далее в левой части уравнения оставляем переменную x, а во второй только значения: k1 * x - k2 * x = b2 - b1

    // Упрощаем: x * (k1 - k2) = b2 - b1   -->   x = (b2 - b1) / (k1 - k2)

    float x = (b2 - b1) / (k1 - k2);

    // Теперь подставляем полученный x в первое уравнение и находим y = k1 * (b2 - b1) / (k1 - k2) + b1

    float y = k1 * (b2 - b1) / (k1 - k2) + b1;

    Console.WriteLine($"Точка пересечения двух наших прямых = ( {x} ; {y} )");
}

Console.WriteLine("У нас есть два уравнения: y = k1 * x + b1, y = k2 * x + b2. Давайте для них введем вручную значения b1, k1, b2 и k2");
Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"У нас получились уравнения: y = {k1} * x + {b1}");
Console.WriteLine($"                            y = {k2} * x + {b2}");
Reshenie(b1, k1, b2, k2);