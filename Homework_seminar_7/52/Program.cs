// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1,11);
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

void MidSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
System.Console.WriteLine($"Среднее арифметичское столба {i+1} = {Math.Round(Convert.ToDouble(sum)/ array.GetLength(0),2)}");
        sum = 0;

    }
}


int m = GetNumber("Write row: ");
int n = GetNumber("Write col: ");
int[,] myArray = new int[m, n];

FillArray(myArray);
PrintArray(myArray);

MidSum(myArray);

