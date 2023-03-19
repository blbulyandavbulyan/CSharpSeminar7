// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
/*
 Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
​
m = 3, n = 4.
​
0,5 7 -2 -0,2
​
1 -3,3 8 -9,9
​
8 7,8 -7,1 9
 */
//This function generate random double 2DArray, values will be [min;max)
double[,] GenerateRandom2DArray(int rows, int columns, double min, double max)
{
    var result = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i, j] = Random.Shared.NextDouble()*max + min;
        }
    }
    return result;
}
void Print2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j + 1 != array.GetLength(1)) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

double[,] randomArray = GenerateRandom2DArray(5, 5, 0, 20);
Print2DArray(randomArray);