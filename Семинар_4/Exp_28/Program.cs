// Задача 28: Напишите программу, которая принимает на вход число N и
//  выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int InputNumber(string text)
{
 System.Console.Write(text);
 return Convert.ToInt32(Console.ReadLine());
}

int Mult (int A)
{
int result = 1;
for (int i = 1; i <= A; i++)
{
    result = i * result;
}
return result;
}




int N = InputNumber("Введите число N: ");
int res = Mult(N);
System.Console.WriteLine(res);
