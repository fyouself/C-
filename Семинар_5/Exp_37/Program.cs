// Задача 37: Найдите произведение пар чиселпроизведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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



// void product_of_pairs_of_numbers(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < (array.Length / 2); i++)
//     {
//         int a = array.Length-1 - i;
//         count = array[i] * array[a];
//         System.Console.WriteLine(count + " ");
//     }
//     if (array.Length % 2 > 0)
//     {
//         int a = array.Length / 2 + 1;
//         System.Console.WriteLine(array[a-1]);
//     }
// }

// product_of_pairs_of_numbers(new_array);



int [] product_of_pairs_of_numbers(int[] array)
{
    int count = 0;
    int[] arr = new int [array.Length/2 + array.Length%2];

    for (int i = 0; i < (array.Length / 2); i++)
    {
        int a = array.Length-1 - i;
        count = array[i] * array[a];
       arr[i] = count;
    }
    if (array.Length % 2 > 0)
    {
        int a = array.Length / 2;
         arr[a] = array[a];
    }
    return arr;
}

int[] sum_array = product_of_pairs_of_numbers(new_array);

System.Console.WriteLine(string.Join("; ", sum_array));
