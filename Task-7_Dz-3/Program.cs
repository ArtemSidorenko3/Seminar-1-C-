// Напишите программу, которая на вход принимает число (N) и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
double a = double.Parse(Console.ReadLine());
 
 if(a % 2 == 1)
 {
    Console.WriteLine("Число: " + a + " (Нечётное)");
 }
 else
 {
    Console.WriteLine("Число: " + a + " (Чётное)");
 }