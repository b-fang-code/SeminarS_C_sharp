// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(1,N));


// string PrintNumbers(int start, int end){
//     if(start == end) return start.ToString();
//     return(start + " " + PrintNumbers(start + 1, end));
// }

//========================================================================================================================================================================

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// Console.Write("Введите M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(M, N));

// string PrintNumbers(int start, int end)
// {
// if (start == end) return start.ToString();
// return (start + " " + PrintNumbers(start + 1, end));
// }


//========================================================================================================================================================================

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("введите число N: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SumNumber(number));

// int SumNumber(int num){
//     if (num==0) return 0;
//     return (num%10 + SumNumber(num/10));
// }


//========================================================================================================================================================================

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(DegreeNumber(A,B));


int DegreeNumber(int A, int B){
    if(B==0)return 1;
    if (B == 1) return A;
    return (A * DegreeNumber(A,B-1));
}