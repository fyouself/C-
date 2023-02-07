// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
string PutNumber(string text)
{
    System.Console.Write(text);
    string? a = Console.ReadLine();
    return a!;
}

int Sum(string a)
{
    int result = 0;
    for (int i = 0; i < a!.Length; i++)
    {
        result = result + Convert.ToInt32(Convert.ToString(a[i]));
    }
    return result;
}

string N = PutNumber("Введите число: ");
System.Console.WriteLine($" Cумма всех чисел: {Sum(N)}");