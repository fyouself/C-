// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetNumber(string text)
{
    System.Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int SumElements(int m, int n)
{
    if (m == n) return m;

    return m + SumElements(m + 1, n);

}


int m = GetNumber("Write M: ");
int n = GetNumber("Write N: ");
System.Console.WriteLine(SumElements(m, n));
