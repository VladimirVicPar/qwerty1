//Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

// Метод переворота

void Number(int num)
{
    int n = num;
    int revers = 0;
    while (n != 0)
    {
        int r = n % 10;
        revers = revers * 10 + r;
        n = n / 10;
    }
    if(num == revers)
    {
        Console.Write($"{num} является палиндромом!");
    }
    else
    {
        Console.Write($"{num} не является палиндромом!");
    }
}

// Проверка на разрядность числа

if(N > 9999 && N <=100000)
{
    Number(N);
}
else 
{
    Console.WriteLine($"Ваше число {N} не является пятизначным, попробуйте ввести заново");
}