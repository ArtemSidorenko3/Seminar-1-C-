// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньше.

Console.WriteLine("Ввудите число 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Максимальное число: " + Math.Max(a,b));

Console.WriteLine("Минимальное число: " + Math.Min(a,b));