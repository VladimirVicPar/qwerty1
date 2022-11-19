// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

// Заполнение массива
int[,] FillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    return array;
}

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}




//Метод для умножения матриц.

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (var k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

//Решение.

int[,] matrixA = CreateArray(2, 2);
int[,] matrixB = CreateArray(2, 2);
matrixA = FillArray(matrixA, 0, 10);
matrixB = FillArray(matrixB, 0, 10);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
PrintArray(matrixC);