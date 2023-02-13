// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void DiffNumbers(int[] array)
{
    int minnumbers = array[0];
    int maxnumbers = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minnumbers > array[i]) minnumbers = array[i];
        if (maxnumbers < array[i]) maxnumbers = array[i];
    }
     System.Console.WriteLine( $"Разницу между макс и мин элементов массива: {maxnumbers -minnumbers}"); 
    }


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

    DiffNumbers(new_array);