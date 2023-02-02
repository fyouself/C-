// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write(" Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 1000)
{
    n = n / 10;
}

if (n > 99)
{
    System.Console.WriteLine(n % 10);
}
else
{
System.Console.WriteLine("третьей цифры нет");
}
