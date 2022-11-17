// ## Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int index = -2;
if (num < 100) Console.WriteLine("Третьей цифры слева нет");
while (num2 > 0)
{
    num2 = num2 / 10;
    index++;
}

index = Convert.ToInt32(Math.Pow(10, index));

num = num % index;
index = index / 10;
num = num / index;

Console.WriteLine(num);