// Решение в группах задач:
// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
}

int[] FullArray(int a)
{
    int[] arrN = new int[a]; 
    for (int i = 0; i < a; i++)
    {
        arrN[i] = new Random().Next(0, 2);
    }
    return arrN;
}

int [] myarray =  FullArray(9);
PrintArray(myarray);

System.Console.WriteLine();
System.Console.WriteLine(myarray.Length);