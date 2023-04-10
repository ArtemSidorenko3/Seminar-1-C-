// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

string day1 = "Понедельник";
string day2 = "Вторник";
string day3 = "Среда";
string day4 = "Четверг";
string day5 = "Пятница";
string day6 = "Суббота";
string day7 = "Воскресенье";

int day = int.Parse(Console.ReadLine());

if(day == 1)
{
    Console.WriteLine(day1);
}
else if(day == 2)
{
    Console.WriteLine(day2);
}
else if(day == 3)
{
    Console.WriteLine(day3);
}
else if(day == 4)
{
    Console.WriteLine(day4);
}
else if(day == 5)
{
    Console.WriteLine(day5);
}
else if(day == 6)
{
    Console.WriteLine(day6);
}
else if(day == 7)
{
    Console.WriteLine(day7);
}
else
{
System.Console.WriteLine("Это не дни недели");
}