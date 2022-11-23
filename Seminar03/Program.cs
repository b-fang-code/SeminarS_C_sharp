// Напишите программу, которая по заданному номеру четверти, показывает диапазон вызможных координат точек в этой четверти (х и у).

// Console.WriteLine("Введите номер четверти: ");
// int number = int.Parse(Console.ReadLine()!);

// switch (number)
// {
//     case 1:
//         {
//             Console.WriteLine("Это первая четверть!");
//             break;
//         }
//     case 2:
//         {
//             Console.WriteLine("Это вторая четверть!");
//             break;
//         }
//     case 3:
//         {
//             Console.WriteLine("Это третья четверть!");
//             break;
//         }
//     case 4:
//         {
//             Console.WriteLine("Это четвёртая четверть!");
//             break;
//         }

//     default:
//         {
//             Console.WriteLine("Такой четверти не существует!");
//             break;
//         }
// }


/// Задача : Определить, является ли заданное шестизначное число счастливым. (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

// Console.WriteLine("Введите шестизначное число: ");
// string numb = Console.ReadLine()!;

// if (numb.Length != 6)
// {
//     Console.WriteLine("Введено неверное число!");
// }
// else
// {
//     if (numb[0] + numb[1] + numb[2] == numb[3] + numb[4] + numb[5])
//     {
//         Console.WriteLine("Это счастливое число!");
//     }
//     else
//     {
//         Console.WriteLine("Это обычное число");
//     }
// }



//  2 вариант
// Console.WriteLine("Введите шестизначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num > 99999 && num < 1000000)
// {
//     Console.WriteLine(num);
//     if (((num / 100000) + ((num / 10000) % 10) + (num / 1000) % 10) == ((num / 100) % 10 + (num / 10) % 10 + (num % 10)))
//     {
//         Console.WriteLine("Число счастливое!");
//     }
//     else{
//         Console.WriteLine("Число не счастливое!");
//     }
// }
// else{
//     Console.WriteLine("Число не шестизначное!");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
// AB = √(xb - xa)2 + (yb - ya)2

// Math - библиотека
// .Sqrt - корень
// .Pow - степень
// Библиотека Math работает с double
// Console.WriteLine($"d={d:f2}");

// int[] arr = { 7, -5, 1, -1 };
// double result = Math.Sqrt(Math.Pow(arr[2] - arr[0],2) + Math.Pow(arr[3] - arr[1],2));
// Console.WriteLine($"результат= {result:f2}");



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{Math.Pow(i, 2)}");
}