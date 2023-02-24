// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

void ArrangeNumbers(int[,] array)
{ var arr = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            arr[j] = array[i,j];


        }
        Array.Sort(arr);
        Array.Reverse(arr);
        System.Console.WriteLine(string.Join("\t",arr));
    }

}

int m = GetNumber("Write row: ");
int n = GetNumber("Write col: ");
int[,] myArray = new int[m, n];

FillArray(myArray);
PrintArray(myArray);
System.Console.WriteLine();

ArrangeNumbers(myArray);