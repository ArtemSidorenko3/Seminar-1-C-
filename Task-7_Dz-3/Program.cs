// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
double a = double.Parse(Console.ReadLine());
 double b = a % 2;
 if(b)
 {
    Console.WriteLine("Четное a число: ");
    Console.WriteLine("Нечетное a число: ");
 }