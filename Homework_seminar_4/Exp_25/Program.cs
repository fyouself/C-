// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int PutNumber(string text)
{
    System.Console.Write(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int Result(int a, int b)
{
    int res = a;
    for(int i = 1; i < b; i++)
    {
        res = res * a;
    }
    return res;
}


int A = PutNumber("Введите число A: ");
int B = PutNumber("Введите число B: ");

System.Console.WriteLine(Result(A, B));
