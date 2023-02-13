// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void CountEvenNumbers (int [] array)
{
int count=0;
for( int i =0 ; i<array.Length; i++)
{
    if (array[i]%2 == 0) 
    {
        count++;
    }
}
System.Console.WriteLine("Количество чётных чисел: " + count);
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


CountEvenNumbers(new_array);

