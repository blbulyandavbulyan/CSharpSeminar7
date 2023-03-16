//Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1 + 9 + 2 = 12
int getDiagonalSum(int[,] arr)
{
    int result = 0;
    for(int i = 0, j = 0; i < arr.GetLength(0) && j < arr.GetLength(1); i++, j++)
    {
        result += arr[i, j];
    }
    return result;
}
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}
int[,] testArr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};
Console.WriteLine(getDiagonalSum(testArr));