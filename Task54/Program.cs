/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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

int[,] SortElementInRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(0); j++) {
            for (int k = 0; k < array.GetLength(1) - 1; k++) {
                if (array[i,k] < array[i,k + 1]) {
                    temp = array[i,k + 1];
                    array[i,k + 1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
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

int[,] myArray = InitArray(6,3);
PrintArray(myArray);
myArray = SortElementInRows(myArray);
PrintArray(myArray);
