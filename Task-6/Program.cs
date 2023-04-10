// Напишите программу, которая на вход принимает одно число (N), а на входе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Ввудите число: ");
int  a = int.Parse(Console.ReadLine());

for (int i = -a; i <= a; i++) // Счетчик
{
    Console.Write(i+" ");
}