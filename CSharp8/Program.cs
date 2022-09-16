{
    Console.WriteLine("Task.54");
    Console.Write("Введите колисчетсво строк: ");
    int ROWS = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int COLUMNS = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[ROWS, COLUMNS];

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }


    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine("Напечатаем массив:");
    PrintArray(array);

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            for (int m = j; m < COLUMNS; m++)
            {
                if (array[i, j] < array[i, m])
                {
                    int temp = array[i, m];
                    array[i, m] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine("Упорядочный массив:");
    PrintArray(array);
}

{
    Console.WriteLine("Task.56");
    int ROWS = 4;
    int COLUMNS = 4;

    int[,] array = new int[ROWS, COLUMNS];

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("Напечатаем массив:");
    PrintArray(array);


    int[] sumRows(int[,] array)
    {
        int[] arr = new int[array.GetLength(0)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int temp = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                temp += array[i, j];
            }
            arr[i] = temp;
        }
        return arr;
    }

    int NumbMinString(int[] arr)
    {
        int min = arr[0];
        int lineNumber = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
                lineNumber = i + 1;
            }
        }
        return lineNumber;
    }

    int[] arrayOfSum = sumRows(array);
    int lineNumber = NumbMinString(arrayOfSum);
    Console.WriteLine(lineNumber + " строка");


}

{
    Console.WriteLine("Task.58");
    int[,] matrix1 = FillMatrix(4, 4);
    Console.WriteLine("Первая матрица: ");
    PrintMatrix(matrix1);
    Console.WriteLine();

    int[,] matrix2 = FillMatrix(4, 4);
    Console.WriteLine("Вторая матрица: ");
    PrintMatrix(matrix2);
    Console.WriteLine();

    Console.WriteLine("Результирующая матрица:");
    int[,] matrix3 = ProductOfMatrix(matrix1, matrix2);
    PrintMatrix(matrix3);

    int[,] FillMatrix(int rows, int columns)
    {
        int[,] matr = new int[rows, columns];

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
        return matr;
    }

    void PrintMatrix(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    int[,] ProductOfMatrix(int[,] matr1, int[,] matr2)
    {
        int[,] newMatr = new int[matr1.GetLength(0), matr1.GetLength(1)];
        for (int i = 0; i < newMatr.GetLength(0); i++)
        {
            for (int j = 0; j < newMatr.GetLength(1); j++)
            {
                newMatr[i, j] = matr1[i, j] * matr2[i, j];
            }

        }
        return newMatr;
    }
}

{
    Console.WriteLine("Task.60");
    int[,,] matrix = FillMatrix(2, 2, 2);
    const int START = 10;

    int[,,] FillMatrix(int x, int y, int z)
    {
        int[,,] matr = new int[x, y, z];
        int[] uniqArr = GetUniqueValue(matr);
        int temp = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    matr[i, j, k] = uniqArr[temp++];
                    Console.Write($"{matr[i, j, k]}({i},{j},{k})  ");
                }
                Console.WriteLine();
            }
        }
        return matr;
    }
    int[] GetUniqueValue(int[,,] matr)
    {
        int[] uniqueArr = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
        int t = START;
        for (int i = 0; i < uniqueArr.Length; i++)
        {
            uniqueArr[i] = t;
            t = t + 1;
        }
        return uniqueArr;
    }

}

{
    Console.WriteLine("Task.62");
    int arrayLength = 4;
    int currentValue = 1;
    int[,] array = new int[arrayLength, arrayLength];

    void PrintArray(int[,] arr)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < 10)
                {
                    Console.Write("0" + array[i, j]);
                    Console.Write(" ");
                }
                else Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    void FillArray(int row, int column, int length, int position)
    {
        while (column < length + position)
        {
            array[row, column++] = currentValue++;
        }

        row++;
        column--;
        while (row < length)
        {
            array[row++ + position, column + position] = currentValue++;
        }

        row--;
        column--;

        while (column >= 0)
        {
            array[row + position, position + column--] = currentValue++;
        }

        row--;
        column++;
        while (row > 0)
        {
            array[row--, column + position] = currentValue++;

        }
        position++;
        if (position < arrayLength / 2)
        {
            FillArray(1, 1, arrayLength / 2, position);
        }
    }

    PrintArray(array);
    FillArray(0, 0, arrayLength, 0);
    PrintArray(array);

}
