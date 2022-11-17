// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Метод вычисления кубов чисел
void Cube(int n)
{
    for (int i = 1; i<=n; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}");
        if(i != n)
        {
            Console.Write(", ");
        }
    }
}

// Решение
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Cube(N);