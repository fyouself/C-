// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("Введите координаты числв А");
int Xa = InputNumber("x: ");
int Ya = InputNumber("y: ");

System.Console.WriteLine("Введите координаты числв  B");
int Xb = InputNumber("x: ");
int Yb = InputNumber("y: ");


System.Console.WriteLine(Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2)));

