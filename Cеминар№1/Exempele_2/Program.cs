// Задача №1. Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
System.Console.WriteLine( " Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine( " Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if ( b * b == a)
    {
        System.Console.WriteLine("Число a яляется квадратом числа b");
    }
else
    {
        System.Console.WriteLine("Число a НЕ яляется квадратом числа b");
    }
