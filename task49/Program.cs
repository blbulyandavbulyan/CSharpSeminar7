//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

//Например, изначально массив
//выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4


//Новый массив будет выглядеть
//вот так:
//1 4 7 2
//5 81 2 9
//8 4 2 4
int[,] generateRandom2DArray(int columns, int rows, int minRandomNumber = 0, int maxRandomNumber = 100)
{
    int[,] result = new int[columns, rows];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            result[i, j] = Random.Shared.Next(minRandomNumber, maxRandomNumber + 1);
        }
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
void TransformArray(int[,] arr)
{
    for(int i = 1; i < arr.GetLength(0); i+=2)
    {
        for(int j = 1; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
}
int[,] arr = generateRandom2DArray(5, 5);
Console.WriteLine("До преобразования: ");
Print2DArray(arr);
Console.WriteLine("После преобразования: ");
TransformArray(arr);
Print2DArray(arr);