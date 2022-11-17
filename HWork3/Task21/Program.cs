// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение. Используем теорему Пифагора.

double Dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result; 
}

// Вводим координаты точек А и В.

Console.WriteLine("Введите x координаты точки А: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y координаты точки А: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z координаты точки А: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x координаты точки B: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y координаты точки B: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z координаты точки B: ");
double z2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Расстояние между точками А и В в 3D пространстве равно: {Dist(x1,y1,z1,x2,y2,z2):f2}");
