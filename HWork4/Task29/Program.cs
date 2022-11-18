// // Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//
// Вместо N вписываем количество элементов [N].
// Числа массива вводим вручную

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//    Console.WriteLine($"Введите число: ");
//    array[i] = int.Parse(Console.ReadLine()!);
// }
//
// Console.Write("Вывод массива: ");
// for (int i = 0; i < array.Length; i++)
// {
//     // if(array[i] > 0)
//    Console.Write($"{array[i]}");
//    if (i < array.Length - 1)
//    {
//        Console.Write(", ");
//    }
// }

// Создаем массив размером N состоящий из случайных чисел
// и выводим его на экран

int[] randomArray(int n)
{
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(0, 100);
        Console.Write(array[i] + " ");
    }
    return array;
}

Console.Write("Введите число: ");
int[] randArray = randomArray(Convert.ToInt32(Console.ReadLine()));