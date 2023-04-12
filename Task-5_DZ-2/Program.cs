// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Ввудите число 1: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine("Максимальное число: " + Math.Max(a, Math.Max(b,c)));
