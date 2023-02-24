// // // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// // // местами первую и последнюю строку массива.


// // void ChanchNum(int[,] array)
// // {
// //     for (int i = 0; i < array.GetLength(1); i++)
// //     {
// //         int temp = array[0, i];
// //         array[0, i] = array[array.GetLength(0)-1,i];
// //         array[array.GetLength(0)-1,i] = temp;

// //     }
// // }
// // void FillArray(int[,] array)
// // {
// //     Random rand = new Random();
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             array[i, j] = rand.Next(1, 11);
// //         }
// //     }
// // }

// // int GetNumber(string text)
// // {
// //     System.Console.Write(text);
// //     int n = Convert.ToInt32(Console.ReadLine());
// //     return n;
// // }

// // void PrintArray(int[,] array)
// // {
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             System.Console.Write(array[i, j] + "\t");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }



// // int m = GetNumber("Write row: ");
// // int n = GetNumber("Write col: ");
// // int[,] myArray = new int[m, n];

// // FillArray(myArray);
// // PrintArray(myArray);
// // System.Console.WriteLine();
// // ChanchNum(myArray);
// // PrintArray(myArray);




// // Задача 55: Задайте двумерный массив. Напишите программу, 
// // которая заменяет строки на столбцы. В случае, если это невозможно, 
// // программа должна вывести сообщение для пользователя.

// // void FillArray(int[,] array)
// // {
// //     Random rand = new Random();
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             array[i, j] = rand.Next(1, 11);
// //         }
// //     }
// // }

// // int GetNumber(string text)
// // {
// //     System.Console.Write(text);
// //     int n = Convert.ToInt32(Console.ReadLine());
// //     return n;
// // }

// // void PrintArray(int[,] array)
// // {
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             System.Console.Write(array[i, j] + "\t");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }

// // int[,] Zamena(int[,] matr)
// // {
// //     int [,] vertical = new int[matr.GetLength(1), matr.GetLength(0)];
// //     for (int i = 0; i < matr.GetLength(1); i++)
// //     {
// //         for (int j = 0; j < matr.GetLength(0); j++)
// //         {
// //         vertical[i,j] = matr[j,i];
// //         }
// //     }
// //     return vertical;
// // }


// // int m = GetNumber("Write row: ");
// // int n = GetNumber("Write col: ");
// // int[,] myArray = new int[m, n];

// // FillArray(myArray);
// // PrintArray(myArray);
// // System.Console.WriteLine();

// // PrintArray(Zamena(myArray));




// // // Задача 57: Составить частотный словарь элементов двумерного массива. 
// // // Частотный словарь содержит информацию о том, сколько раз встречается элемент
// // // входных данных


// // void FillArray(int[,] array)
// // {
// //     Random rand = new Random();
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             array[i, j] = rand.Next(0, 10);
// //         }
// //     }
// // }

// // int GetNumber(string text)
// // {
// //     System.Console.Write(text);
// //     int n = Convert.ToInt32(Console.ReadLine());
// //     return n;
// // }

// // void PrintArray(int[,] array)
// // {
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             System.Console.Write(array[i, j] + "\t");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }

// // void CountElements(int[,] array)
// // {
// //     for (int k = 0; k < 10; k++)
// //     {
// //         int count =0;
// //         for (int i = 0; i < array.GetLength(0); i++)
// //         {
// //             for (int j = 0; j < array.GetLength(1); j++)
// //             {
// //                 if ( k==array[i,j])
// //                 {
// //                     count++;
// //                 }

// //             }
// //         }
// //         if (count!=0)
// //         {
// //             System.Console.WriteLine($" Элемент {k} встречается = {count}");
// //         }
// //     }
// // }
// // int m = GetNumber("Write row: ");
// // int n = GetNumber("Write col: ");
// // int[,] myArray = new int[m, n];

// // FillArray(myArray);
// // PrintArray(myArray);
// // System.Console.WriteLine();

// // CountElements(myArray);







//   // Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// int m = ReadInt("Укажите количество строк: ");
// int n = ReadInt("Укажите количество столбцов: ");
// var myMatrix = GenerateMatrix(m, n);
// PrintMatrix(myMatrix);
// PrintResult(GetArray(myMatrix));


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     var rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 100000);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     System.Console.WriteLine("Сгенерирована матрица:");
//     System.Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] GetArray(int[,] matrix)
// {
//     int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[count] = matrix[i, j];
//             count++;
//         }
//     }
//     return array;
// }

// void PrintResult(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == 0)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine($"Число 0 встречается {count} раз");

//     int number = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         number = array[i];
//         count = 0;
//         if (number == 0)
//         {
//             continue;
//         }
//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[j] == number)
//             {
//                 count++;
//                 array[j] = 0;
//             }
//         }
//         System.Console.WriteLine($"Число {number} встречается {count} раз");
//     }

//     // for (int i = 0; i < array.Length; i++)
//     // {

//     // }

// }






// // Задача 59: Задайте двумерный массив из целых чисел. 
// // Напишите программу, которая удалит строку и столбец, на пересечении 
// // которых расположен наименьший элемент массива.


void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

int GetNumber(string text)
{
    System.Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] FindRowCol(int[,] array)
{
    var rowCol = new int[2];
    int min = array[0, 0];
    int rowForDelite = 0;
    int colForDelite = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                rowForDelite = i;
                colForDelite = j;
            }
        }
    }
    rowCol[0] = rowForDelite;
    rowCol[1] = colForDelite;
    return rowCol;

}

int[,] DeliteRowCol(int[] RowCol, int[,] array)
{
    var newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int l = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != RowCol[0])
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {

                if (j != RowCol[1])
                {
                    newArray[k, l] = array[i, j];
                    l++;
                }
            }
            k++;
        }
        l = 0;
    }
    return newArray;
}

int m = GetNumber("Write row: ");
int n = GetNumber("Write col: ");
int[,] myArray = new int[m, n];

FillArray(myArray);
PrintArray(myArray);
System.Console.WriteLine();

int[] RowCol = FindRowCol(myArray);

System.Console.WriteLine(string.Join(", ", RowCol));
PrintArray(DeliteRowCol(RowCol, myArray));



