// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
Random rand = new Random();
int number = rand.Next(10, 100); // [10; 100)

System.Console.WriteLine($" Random number: {number} ") ;

int Leftnumber = number/10;
int Rigthnumber = number%10;

// System.Console.WriteLine($" Leftnumber= {Leftnumber}  Rigthnumber = {Rigthnumber} ") ;

if (Leftnumber>Rigthnumber)
{
    System.Console.WriteLine("Left number biggest");
}
else if(Rigthnumber>Leftnumber)
{
 System.Console.WriteLine("Right mumber bigeest");
}
 else
 {
    System.Console.WriteLine("Number ravno");
 }