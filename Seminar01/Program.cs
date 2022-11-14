//1!!!  Напишите программу, которая на вход принимает числа и выводит его в квадрат (число умноженное на само себя).

// Вариант 1

/*
Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} = {sqr}");
*/

// Вариант 2

/*
Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {sqr1}");
*/

// 2!!! Напишите программу, которая на входе принимает число N и на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = -N;
while (N2 <= N)
{
    Console.Write($"{N2} ");
    N2++;
}
*/

// 3!!! Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа(последняя цифра это остаток от деления на 10)

/*
Console.WriteLine("Введите трёхзначное число: ");
int N = int.Parse(Console.ReadLine()!);
int S = N%10;
Console.Write($"Последняя цифра {S} ");
*/

// 4!!! Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// a=5; b=25 -> да
// a=2; b=10 -> нет
// a=9; b=-3 -> нет
// a=-3; b=9 -> да

/*
Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
int sqr3 = first * first;
if (second == sqr3)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

*/

// 5!!! Напишите программу, которая будет выдавать название дня недели по заданному номеру: 1 -> понедельник; 2-> вторник и т.д...


Console.WriteLine("Введите порядковый номер дня недели: ");
int daynum = int.Parse(Console.ReadLine()!);
if (daynum ==1) Console.WriteLine("Это понедельник");
if (daynum ==2) Console.WriteLine("Это вторник");
if (daynum ==3) Console.WriteLine("Это среда");
if (daynum ==4) Console.WriteLine("Это четверг");
if (daynum ==5) Console.WriteLine("Это пятница");
if (daynum ==6) Console.WriteLine("Это суббота");
if (daynum ==7) Console.WriteLine("Это воскресенье");


