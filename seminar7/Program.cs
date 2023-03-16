// See https://aka.ms/new-console-template for more information
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
//demo task 46
//эта функция генерирует двумерный массив заданных размеров с случайными элементами принадлежащих промежутку [0; 100]
int[,] generateRandom2DArray(int columns, int rows, int minRandomNumber = 0, int maxRandomNumber = 100)
{
    int[,] result = new int[columns, rows];
    for(int i = 0; i < columns; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            result[i, j] = Random.Shared.Next(minRandomNumber, maxRandomNumber + 1);
        }
    }
    return result;
}
void Print2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}
int[,] randomArray = generateRandom2DArray(20, 20);
Print2DArray(randomArray);