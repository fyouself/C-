﻿// Задача 4: Напишите программу, которая принимает на вход три
//числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Enter three numbers");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a; 

if (max < b)
{
max = b;
}

if (max < c)
{
max = c;
}

System.Console.WriteLine("max = " + max);
