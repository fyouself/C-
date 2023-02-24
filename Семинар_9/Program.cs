// // // // Задача 63: Задайте значение N. Напишите программу, которая выведет 
// // // // все натуральные числа в промежутке от 1 до N.
// // // // N = 5 -> "1, 2, 3, 4, 5"
// // // // N = 6 -> "1, 2, 3, 4, 5, 6"


// // // void NaturNumber(int n, int k)
// // // {
// // //     if (n < k) return;
// // //      System.Console.Write($"{k}, ");
// // //     NaturNumber(n, k + 1);  
// // // }
// // // NaturNumber(8, 1);

  



// // Задача 67: Напишите программу, которая будет 
// // принимать на вход число и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9

// // int SumNumbers(int n)
// // {
// //     if (n == 0) return 0;
// //     return n % 10 + SumNumbers(n / 10);
// // }
// // System.Console.WriteLine(SumNumbers(123));





// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int SqareNumber(int A, int B)
{
    if (B==1) return A;
    return A*SqareNumber(A, B-1);
}
System.Console.WriteLine(SqareNumber(2,3));