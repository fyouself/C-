// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int PutNumber(string text)
{
    System.Console.Write(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[] AddRandomArray(int Size, int leftLimit, int rigthLimit)
{
    int[] newArray = new int[Size];

    for (int i = 0; i < Size; i++)
    {
        newArray[i] = new Random().Next(leftLimit, rigthLimit);
    }
    return newArray;
}

int Size = PutNumber("Введите развер массива: ");
int leftLimit = PutNumber("Введите левую границу чисел: ");
int rigthLimit = PutNumber("Введите правую границу чисел: ");

int[] new_array = AddRandomArray(Size, leftLimit, rigthLimit);

System.Console.WriteLine("Ваш массив чисел [" + string.Join(", ", new_array) + "]");

void FindCound(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>9 && array[i]<100)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество цифр в прделе [10;99] = {count}" );
}


FindCound (new_array);