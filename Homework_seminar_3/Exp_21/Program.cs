// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("Введите координаты числв А");
int Xa = InputNumber("x: ");
int Ya = InputNumber("y: ");
int Za = InputNumber("z: ");

System.Console.WriteLine("Введите координаты числв  B");
int Xb = InputNumber("x: ");
int Yb = InputNumber("y: ");
int Zb = InputNumber("z: ");


System.Console.WriteLine(Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2)+ Math.Pow((Zb - Za), 2)));

