// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


//Cоздание массива.

int[] creadeArray(int n)
{
    int[] array = new int[n];
    return array;
}

//Заполнение массива рандомными значениями.

int[] fillArray(int[] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

//Печать массива. 

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Подсчет суммы элентов массива с нечетными индексами.

int sumOddinIndexDigits(int[] array)

{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

//Решение.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = creadeArray(n);
array = fillArray(array, -100, 100);
printArray(array);
Console.WriteLine($"-> {sumOddinIndexDigits(array)}");
