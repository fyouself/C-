// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i =  n/10;
int e = n/1000;
if (n/10000 == n%10  && e%10 == i%10 )
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}



