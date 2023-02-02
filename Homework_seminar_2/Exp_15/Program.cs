// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>7)
{
    System.Console.WriteLine("Такого дня недели нет");
}
else if ( n== 7 || n==6)
{
    System.Console.WriteLine("Да");
}
else 
{
    System.Console.WriteLine("Нет");
}
