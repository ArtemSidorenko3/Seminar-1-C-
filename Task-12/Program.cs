/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратное числу 1, то программа выводит остаток от деления*/
System.Console.WriteLine("Введите число 1: ");

double a = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");

double b = double.Parse(Console.ReadLine());

double c = a % b;

if (a % b == 0)
{
    System.Console.WriteLine($"Первое число {a} Кратно первому {b}");
}
else
{
    System.Console.WriteLine($"Первое число {a}  Не кратно второму {b} остаток от деления {c}");
}