// Напишите программу, которая выводит случайное трхзначное число и удаляет вторую цифру этого числа.


int number = new Random().Next(100, 1000); // Рандомное число

System.Console.WriteLine(number);// Вывод переменной number на экран

int number1 = number / 100;
System.Console.WriteLine(number1);

int number2 = number % 10;
System.Console.WriteLine(number2);
System.Console.WriteLine($"{number1}{number2}"); //Console.WriteLine(number1 * 10 + number2); или Console.WriteLine("" + number1 + number2);



