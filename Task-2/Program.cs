// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите число: ");

 int number1 = int.Parse(Console.ReadLine());
 int number2 = int.Parse(Console.ReadLine());

if(number1 == Math.Pow(number2, 2))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}