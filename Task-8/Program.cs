// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine(a%10);
