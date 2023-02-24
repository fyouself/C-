// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер
//  строки с наименьшей суммой элементов: 1 строка


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

void FindRowMinsum(int[,] array)
{
    int rowMinsum = 1;
    int sum = 0;
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            if (i == 0)
            {
                temp = sum;
            }
        }
        if (sum < temp)
        {
            temp = sum;
            rowMinsum = i + 1;
        }
    }
    System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {rowMinsum} строка");
}


int m = GetNumber("Write row: ");
int n = GetNumber("Write col: ");
int[,] myArray = new int[m, n];

if (m == n) System.Console.WriteLine("Ведите прямоугольный массив");
else
{
    FillArray(myArray);
    PrintArray(myArray);
    System.Console.WriteLine();
    FindRowMinsum(myArray);
}