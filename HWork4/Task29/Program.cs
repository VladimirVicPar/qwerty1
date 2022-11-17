// // Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//
// Вместо N вписываем количество элементов [N].
// Числа массива вводим вручную

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число: ");
    array[i] = int.Parse(Console.ReadLine()!);
}

Console.Write("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
    // if(array[i] > 0)
    Console.Write($"{array[i]}");
    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
}

// Программа задает массив из 15 элементов и наполняет его произвольными элементами
//
// int[] array = new int[15];
// void FillArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(2,31);
// }
// }
// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length - 1; i++)
// {
//     Console.Write($"{array[i]}, ");
// }
// Console.Write($"{array[array.Length - 1]} ");
// }
// PrintArray(array);
// Console.WriteLine();
// FillArray(array);
// PrintArray(array);