// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//int number = new Random().Next(10, 100); // Рандомный вывод чисел от 10 до 100.
//int first = number / 10;
//int second = number % 10;

//System.Console.WriteLine(number);

//if (first > second)
//{
//    System.Console.WriteLine("Первое больше");
//}
//else
//{
//    System.Console.WriteLine("Второе больше");
//}



System.Console.WriteLine("min");
int min = ReadInt();

System.Console.WriteLine("max");
int max = ReadInt();

int number = GetRandomNumber(min, max);

System.Console.WriteLine(number);

if(GetFirstDigit(number) > GetSecondDigit(number))
{
    System.Console.WriteLine("second");

}
else
{
System.Console.WriteLine("second");
}

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int GetFirstDigit(int number)
{
    return number / 10;
}

int GetSecondDigit(int number)
{
    return number % 10;
}

int ReadInt()
{
   return int.Parse(Console.ReadLine());
}