// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


string InputNumber (string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}

void Count (string a)
{
 System.Console.WriteLine($"Количесво цифр в числе: {a.Length}");
}

string number = InputNumber("Введите число: ");

Count (number);
