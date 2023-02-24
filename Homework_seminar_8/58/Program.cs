// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
            // array[i, j] = Convert.ToInt32(Console.ReadLine());
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


int[,] MultupMatrix(int[,] arr1, int[,] arr2)
{
    int[,] newarr = new int[arr1.GetLength(0), arr1.GetLength(0)];

    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        System.Console.WriteLine(" Первая матрица должна имеет такое же количество столбцов, как вторая  матрица  строк");
    }

    else
    {

        for (int i = 0; i < newarr.GetLength(0); i++)
        {

            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                
                for (int k = 0; k < arr2.GetLength(0); k++)
                {

                    newarr[i, j] += arr1[i, k] * arr2[k, j];
                }
                
                 
            }



        }

    }

    return newarr;
}

System.Console.WriteLine("Введите первую матрицу");
int m = GetNumber("Write row: ");
int n = GetNumber("Write col: ");
int[,] array1 = new int[m, n];
FillArray(array1);
PrintArray(array1);
System.Console.WriteLine();

System.Console.WriteLine("Введите вторую матрицу");
int a = GetNumber("Write row: ");
int b = GetNumber("Write col: ");
int[,] array2 = new int[a, b];
FillArray(array2);
PrintArray(array2);
System.Console.WriteLine();


int[,] matrix = MultupMatrix(array1, array2);
PrintArray(matrix);


