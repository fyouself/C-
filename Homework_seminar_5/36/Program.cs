// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SumOddNumbers(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    System.Console.WriteLine("Cумму элементов, стоящих на нечётных позициях: " + count);

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


SumOddNumbers(new_array);