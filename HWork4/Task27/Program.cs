// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumNumbers(int num)
{
    int n = num;
    int rev = 0;
    while (n != 0)
    {
        int r = n % 10;
        rev = rev + r;
        n = n / 10;
    }
    return rev;
}


Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {N} равна: {SumNumbers(N)}");