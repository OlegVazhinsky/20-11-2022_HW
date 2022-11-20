/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

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

int[,] ArrayMultiplication(int[,] firstArray, int[,] secondArray)
{
    int[,] multArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < multArray.GetLength(0); i++) {
        for (int j = 0; j < multArray.GetLength(1); j++) {
            for (int k = 0; k < firstArray.GetLength(1); k++) {
                multArray[i,j] += firstArray[i,k] * secondArray[k,j];
            }
        }
    }
    return multArray;
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

int[,] firstArray = InitArray(2,3);
int[,] secondArray = InitArray(3,4);
PrintArray(firstArray);
PrintArray(secondArray);

if (firstArray.GetLength(1) != secondArray.GetLength(0)) Console.WriteLine($"Матрицы не могут быть перемножены");
else {
    int[,] multArray = ArrayMultiplication(firstArray, secondArray);
    PrintArray(multArray);
}
