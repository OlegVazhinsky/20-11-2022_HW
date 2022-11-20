/*

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = rnd.Next(9);
        }
    }
    return array;
}

int RowWithMinimalElementsSum(int[,] array)
{
    int rowSum = 0;
    int minSum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            rowSum += array[i,j];
        }
        if (i == 0) minSum = rowSum;
        if (rowSum < minSum) {
            minSum = rowSum;
            index = i + 1;
        }
        rowSum = 0;
    }
    if (index == 0) index = 1;
    return index;
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

int[,] myArray = InitArray(6,3);
PrintArray(myArray);
int minimalIndex = RowWithMinimalElementsSum(myArray);
Console.WriteLine($"Минимальная сумма элементов в строке {minimalIndex}");
