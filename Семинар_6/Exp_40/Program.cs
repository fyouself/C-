
// var [] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);



// Задача 42: Напишите программу, которая будет преобразовывать десятичное
//  число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10
//  System.Console.WriteLine("Введите число: ");
//  int number = Convert.ToInt32(Console.ReadLine());
//  int count=1;
//  int temp = number;
// while(temp>1)
// {
//     count++;
//     temp /=2;
// }
// int [] array = new int[count];
// for ( int i = 0; i < count; i++  )
// {
// array[i] = number%2;
// number = number/2;
// }
// Array.Reverse(array);
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");



// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = new int[number];
array[0] = 0;
array[1]= 1;
for (int i = 2; i <number; i++)
{
    array[i]=array[i-1] + array[i-2];
}
System.Console.WriteLine("[" + string.Join(", ", array) + "]");