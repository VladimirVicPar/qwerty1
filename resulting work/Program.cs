// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

//Метод, который считывает строку с консли.

string ReadString()
{
    WriteLine("Введите слова через пробел");
    return ReadLine()!;
}

// Метод, который преобразует строку в массив строк.

string[] StringToArray(string s)
{
    string[] stringArray = s.Split(" ");
    return stringArray;
}

//Метод, который создает массив только из элементов меньше трех символов. 

string[] CreateMaxThreeDigitsArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] targetArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            targetArray[count] = array[i];
            count++;
        }
    }
    return targetArray;
}

//Метод печати массива.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Решение.

string str = ReadString();
string[] array = StringToArray(str);
string[] targetArray = CreateMaxThreeDigitsArray(array);
WriteLine();
PrintArray(targetArray);
