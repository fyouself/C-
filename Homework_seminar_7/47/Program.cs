// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void FillArray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * rand.Next(-10, 11), 1);
        }
    }
}

int GetNumber(string text)
{
    System.Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void PrintArray(double[,] array)
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

int m = GetNumber("Write row: ");
int n = GetNumber("Write col: ");
double[,] myArray = new double[m, n];

FillArray(myArray);
PrintArray(myArray);










