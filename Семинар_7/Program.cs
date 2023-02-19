// // Решение в группах задачи:

// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в
// //  массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // rows = 3, cols = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5


// // int PutNumber(string text)
// // {
// //     System.Console.Write(text);
// //     int n = Convert.ToInt32(Console.ReadLine());
// //     return n;
// // }

// // int[,] FillMatrix(int row, int col)
// // {
// //     int[,] matrix = new int[row,col];

// //     for (int i = 0; i < row; i++)
// //     {
// //         for (int j = 0; j < col; j++)
// //         {
// //             matrix[i,j] = i+j;

// //         }
// //     }
// //     return matrix;
// // }
// // void PrinMatrix(int[,] matrix)
// // {
// //    for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             System.Console.Write(matrix[i,j] + "\t");
// //         }
// //         System.Console.WriteLine();
// //     } 
// // }

// // int row = PutNumber ("Write row: ");
// // int col = PutNumber ("Write colloms: ");

// // int [,] myMatrix = FillMatrix(row,col);
// // PrinMatrix ( myMatrix);






// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// // оба индекса нечётные, и замените эти элементы на их квадраты.


// int PutNumber(string text)
// {
//     System.Console.Write(text);
//     int n = Convert.ToInt32(Console.ReadLine());
//     return n;
// }
// int[,] FillMatrix(int row, int col)

// {
//     int[,] matrix = new int[row, col];

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void PrinMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// void FindChange(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j % 2! > 0 && i % 2! > 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         }
//     }
// }
// int row = PutNumber("Write row: ");
// int col = PutNumber("Write colloms: ");

// int[,] myMatrix = FillMatrix(row, col);
// PrinMatrix(myMatrix);

// System.Console.WriteLine();

// FindChange(myMatrix);
// PrinMatrix(myMatrix);

// Тернарная переменная 
int x =9;
int y = 6;
int res = (x>y)? x+y: x*y;
System.Console.WriteLine(res);
