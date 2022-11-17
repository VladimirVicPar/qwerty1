// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Expo(int A, int B);
{
    int n = A;
    for (int i = 2; i <= B; i++)
    n = n * A;
    return n; 
}

// Решение

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {a}, возведенное в степень {b} равно: {Expo(a,b)}"); 