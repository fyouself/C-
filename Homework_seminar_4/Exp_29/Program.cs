// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
//  выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

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

int[] array = AddRandomArray(Size, leftLimit, rigthLimit);

System.Console.WriteLine("Ваш массив чисел [" + string.Join(", ", array) + "]");