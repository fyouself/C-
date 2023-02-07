// // Напишите программу, которая по заданному номеру четверти, показывает диапазон
// //  возможных координат точек в этой четверти (x и y).

int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}


void ShowDiapozon(int a, int b)
{
    if (a > 0 && b > 0)
    {
        System.Console.WriteLine("Четверть 1");
    }
    else if (a < 0 && b > 0)
    {
        System.Console.WriteLine("Четверть 2");
    }
     else if (a < 0 && b < 0)
    {
        System.Console.WriteLine("Четверть 3");
    }
     else if (a > 0 && b < 0)
    {
        System.Console.WriteLine("Четверть 4");
    }


}
int x = InputNumber("Введите X: ");
int y = InputNumber("Введите Y: ");
ShowDiapozon (x,y);

