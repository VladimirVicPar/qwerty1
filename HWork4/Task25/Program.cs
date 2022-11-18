// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int power(int A, int B)
{
    int power = A;
    for (int i = 2; i <= B; i++)
    {
        power = power * A;
    }
    return power;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите cтепень: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(power(A, B));