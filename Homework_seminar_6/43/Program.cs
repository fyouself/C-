﻿//  Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//  задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Write k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Write b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Write k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Write b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

double[] IntersectionLines(double k1, double b1, double k2, double b2)
{
double x;
double y;
x = (b2-b1)/(k1-k2);
y = k1 * x + b1;
System.Console.WriteLine(x);
double [] array = {x , y};
return array;
}


double [] XandY = IntersectionLines( k1,  b1,  k2, b2);
System.Console.WriteLine("{" + string.Join(", ", XandY) + "}");
