// напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

System.Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

if(a * a == b || b * b ==a)
{
System.Console.WriteLine("Является квадратом одного числа к другому!");
}
else
{
System.Console.WriteLine("Не является квадратом одного числа к другому!");
}