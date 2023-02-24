﻿// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;

    if (n == 0) return Akkerman(m - 1, 1);

    if (n > 0 && m > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman( m,  n);
}


int GetNumber(string text)
{
    System.Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int m = GetNumber("Write M: ");
int n = GetNumber("Write N: ");
System.Console.WriteLine(Akkerman(m, n));
