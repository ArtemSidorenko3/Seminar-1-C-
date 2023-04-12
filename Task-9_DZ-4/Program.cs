// Напишите программу, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

for (int i = 2; i <= a; i += 2)
{
    if (i < a - 1)
    Console.WriteLine(i);

    else
    Console.WriteLine (i);
}