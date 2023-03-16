// See https://aka.ms/new-console-template for more information
//demo task 46
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