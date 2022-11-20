/*

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    int size = m * n;
    int i = 0;
    int j = 0;
    int value = 1;
    while (value <= size) {
        array[i, j] = value;
        if (i <= j + 1 && i + j < n - 1) j += 1;
        else if (i < j && i + j >= n-1) i += 1;
        else if (i >= j && i + j > n-1) j -= 1;
        else i -= 1;
        value += 1;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = InitArray(3,3);
PrintArray(myArray);
