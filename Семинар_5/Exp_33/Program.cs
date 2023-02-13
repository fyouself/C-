// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void FindNumber(int[] array, int Number)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number)
        {
            a++;
        }

    }
    if (a > 0)
    {
        System.Console.WriteLine("Yes");
    }
    else System.Console.WriteLine("NO");

}


int[] array = { 6, 7, 19, 345, -3 };
PrintArray(array);

FindNumber(array, 4);
