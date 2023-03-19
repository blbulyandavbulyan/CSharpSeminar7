/*
 Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
​
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */
//Возвращает массив, длинна которого совпадает с количеством столбцов с каждым элементом, а значения равны средним арифметическим для столбцов соответственно
double[] GetAverageForCoulumns(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            result[i] += arr[j, i];
        }
        result[i]/= arr.GetLength(0);
    }
    return result;
}
int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4, }
};
Console.WriteLine(string.Join(' ', GetAverageForCoulumns(arr)));