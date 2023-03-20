//Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
int[,] getPasccalthreeAngle(int n)
{
    int columns = 2*n - 1;//это количество чисел в последней строке треугольника паскаля, оно же и будет количеством столбцов, то что оно нечёнтное, я этим буду дальше пользоваться
    int[,] matrix = new int[n, columns];//двумерный массив, который будет содержать наш треугольник

    //это индекс столбца ровно посередине, справа и слева одинаковое количество элементов
    int middleColumnIndex = matrix.GetLength(1) / 2;//благодаря тому что количество столбцов у нас не чётное, мы легко можем получить такой индекс,
                                                      //чтобы слева и справа от него было одинаковое количество элементов, т.к. наш треугольник симетричен
    
    // заполняем верхние грани треугольника еденицами
    for (int i = 0, j = middleColumnIndex; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
    {
        matrix[i, j] = 1;//заполнение левой грани
        matrix[i, middleColumnIndex - i] = 1;//заполнение правой грани
    }
    //цикл перебора строк, начинаем с 1 поскольку нам нужно получать доступ к верхней строке
    for(int i = 1; i < n; i++)
    {
        int endColumnPosition = middleColumnIndex + i;//позиция на которой должен закончится внутренний цикл
        int startColumnPosition = middleColumnIndex - i + 1;//здесь мы вычитаем i чтобы попасть в столбец где стоит цифра один,
                                                            //а прибавляем 1, т.к. нам нужно заполнять треугольник внутри
                                                            //(уже заполненные грани единицами не трогаем)
        for (int j = startColumnPosition; j < endColumnPosition; j++)
        {
            int leftTop = matrix[i - 1, j - 1];//элемент сверху от текущего и слева
            int rightTop = matrix[i - 1, j + 1];//элемент сверху от текущего и справа
            matrix[i, j] = leftTop + rightTop;
        }
    }
    return matrix;
}
void PrintPascalThreeAngle(int n)
{
    int[,] pascalMatrix = getPasccalthreeAngle(n);
    for(int i = 0; i < pascalMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < pascalMatrix.GetLength(1); j++)
        {
            Console.Write(pascalMatrix[i, j] == 0 ? " " : $"{pascalMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j + 1 != array.GetLength(1)) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

PrintPascalThreeAngle(11);