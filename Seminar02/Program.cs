// Нужно написать программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// Первый метод (математический)
// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// Console.WriteLine($"Число без второй цифры имеет вид: {number / 100}{number % 10}"); // -1 способ
// Console.WriteLine();
// int result = (number / 100 * 10 + number % 10); // -2 второй способ
// Console.WriteLine(result);



// Второй метод (строковый)
// Console.WriteLine("Введи трехзначное число: ");
// string Numbers = Console.ReadLine()!;

// if(Numbers.Length !=3){
//     Console.WriteLine("Введено неверное число!");
// }

// else{
//     Console.WriteLine($"Число без второй цифры имеет вид: {Numbers[0]}{Numbers[2]}");
// }



// Строка: 1...бесконечности,  символы ;:'"<> и т.д. и буквы JLKJDL
// Массив: 1....бесконечность



// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// int randnum = new Random().Next(10, 100);

// Console.WriteLine(randnum);
// if (randnum/10 > randnum%10)
// {
//     Console.WriteLine($"Наибольшая цифра {randnum/10}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра {randnum%10}");
// }



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// Первое число делится на второе
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a % b == 0)
// {
//     Console.WriteLine($"Первое число {a} кратно второму числу {b} ");
// }
// else
// {
//     Console.WriteLine($"Первое число {a} не кратно второму числу {b} и остаток равен {a % b} ");
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine($"Число {num} кратно 7 и 23 ");
// }
// else
// {
//     Console.WriteLine($"Число {num} НЕ кратно 7 и 23 ");
// }



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine()!);
if (numb1 == numb2 * numb2 || numb2 == numb1 * numb1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}
