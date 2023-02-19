// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.

// Например, задан массив:

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

void FindPosition(double[,] array)
{
    int row = GetNumber("Введите строчку: ");
    int col = GetNumber("Введите столбец: ");
    if (array.GetLength(0) < row || array.GetLength(1) < col)
    {
        System.Console.WriteLine(" Такого элемена нет ");
    }
    else
    {
        System.Console.WriteLine("Ваше число: " + array[row-1,col-1]);
    }
}
Random rand = new Random();
int m = rand.Next(1, 10);
int n = rand.Next(1, 10);
double[,] myArray = new double[m, n];

FillArray(myArray);
FindPosition(myArray);
PrintArray(myArray);
