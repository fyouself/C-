// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


System.Console.Write("Write number one: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A < 1000 && A > 99)
{
    A = A / 10;
    System.Console.WriteLine(A % 10);
}

 else
{
    System.Console.WriteLine("Введено не трёхзначное число ");
}



