// See https://aka.ms/new-console-template for more information
/**
 Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
​
Например, задан массив:
​
1 4 7 2
​
5 9 2 3
​
8 4 2 4
​
1 7 -> такого числа в массиве нет
 */
Main();
void Main()
{
    //решил сделать тут через перехват исключения, что считаю красивым
    try
    {
        //генерирую массив со случайными числами в промежутке [0; 100)
        //и со случайным количеством столбцов и строк в промежутке [5;10]
        var randomArray = GenerateRandom2DArray(
            Random.Shared.Next(5, 11),
            Random.Shared.Next(5, 11),
            0, 100);                             
        Print2DArray(randomArray);
        int row = GetInt("Введите индекс строки: ");
        int column = GetInt("Введите индекс столбца: ");
        Console.WriteLine(randomArray[row, column]);
    }
    catch(IndexOutOfRangeException e)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
}

int[,] GenerateRandom2DArray(int rows, int columns, int min, int max)
{
    var result = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i, j] = Random.Shared.Next(min, max);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int GetInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}