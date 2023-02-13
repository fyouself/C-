// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из
//  промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
//  равна 29, сумма отрицательных равна -20.


int[] fillArray(int size, int leftLimit, int rigthLimit)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(leftLimit, rigthLimit);
    }
    return newArray;
}

int[] arr = fillArray(12, -9, 9);
System.Console.WriteLine(string.Join(", ", arr));

void sumNegativNumbers(int[] yourArray)
{
    int resalt = 0;
    for (int i = 0; i < yourArray.Length; i++)
    {
        if (yourArray[i] < 0) resalt = resalt + yourArray[i];

    }
    System.Console.WriteLine(resalt);
}

void sumPositivNumbers(int[] yourArray)
{
    int resalt = 0;
    for (int i = 0; i < yourArray.Length; i++)
    {
        if (yourArray[i] > 0) resalt = resalt + yourArray[i];

    }
    System.Console.WriteLine(resalt);
}

sumNegativNumbers(arr);
sumPositivNumbers(arr);


