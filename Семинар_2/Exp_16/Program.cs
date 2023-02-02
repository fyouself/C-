// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.Write("Write number one: ");
int N1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write number two: ");
int N2 = Convert.ToInt32(Console.ReadLine());

if (N1*N1 == N2)
{
    System.Console.WriteLine("Yes");
}
else if (N2*N2 == N1)
{
    System.Console.WriteLine("Yes");
}
else 
{
    System.Console.WriteLine("No");
}
