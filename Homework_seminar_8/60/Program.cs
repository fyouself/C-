// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(10, 100);
            }

        }
    }
}

int GetNumber(string text)
{
    System.Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
            }
              System.Console.WriteLine();
        }
      
    }
}



System.Console.WriteLine("Введите парметры массива");
int x = GetNumber("Write x: ");
int y = GetNumber("Write y: ");
int z = GetNumber("Write z: ");
int[,,] array1 = new int[x,y,z];
FillArray(array1);
PrintArray(array1);
System.Console.WriteLine();


