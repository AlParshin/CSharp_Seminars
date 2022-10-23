// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double ShowDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

Console.WriteLine("Введите координаты первой точки. Сначала x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки. Теперь у1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки. И наконец z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки. Сначала x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки. Теперь у2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки. И наконец z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = ShowDistance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между нашими двумя точками в 3D пространстве равно {result}");