
System.Console.Write("Введите число: ");
string n = Console.ReadLine(); 

if( n[0]==n[4])
{
    System.Console.WriteLine("Win");
}
System.Console.WriteLine(n[2]);

int number = Convert.ToInt32(Convert.ToString(n[3]));
System.Console.WriteLine(number);

System.Console.WriteLine(n.Length);