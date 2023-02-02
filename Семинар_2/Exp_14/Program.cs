// Напишите программу, которая принимает на вход число и проверяет, к
// ратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

System.Console.Write("Write number one: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A % 7 == 0)
{
    if (A % 23 == 0)
    {
        System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }
}
else
{
    System.Console.WriteLine("No");
}