/////////////////////////////// Задача 39: Напишите программу, которая перевернёт одномерный массив
/////////////////////////////// (последний элемент будет на первом месте, а первый на последнем и т.д.)

/*
int[] array = GetArray(10, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] result = ReverseArray2(array);
Console.WriteLine($"Второй метод: [{String.Join(", ", result)}]");

ReverseArray1(array);
Console.WriteLine($"Первый метод: [{String.Join(", ", array)}]");

///////////////////// Method  ////////////////////////

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

///////////////////// Method1  ////////////////////////

void ReverseArray1(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

///////////////////// Method2  //////////////////////// 

int[] ReverseArray2(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
    }
    return result;
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*
Console.WriteLine("Введите 1 число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 3 число: ");
int C = int.Parse(Console.ReadLine()!);
Three(A, B, C);

void Three(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        Console.WriteLine("Да");
    }
    else
        Console.WriteLine("Нет");

}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//Делится число на 2 и записываются его остатки с конца в начало

/*
Console.WriteLine("Введите  число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(Conv(num));

string Conv(int num)
{
    string result = "";
    while (num != 0)
    {
        int num1 = num % 2;
        num = num / 2;
        string num3 = Convert.ToString(num1);
        result = result + num1;
    }
    return result;
}
*/


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//  Числа Фибоначчи — числовая последовательность, каждый элемент которой равен сумме двух предыдущих.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
/*
int n = 20;
int first = 0;
int second = 1;
Console.Write($"{first} {second}");

for (int i = 3; i <= n; i++){
    int num = 0;
    num = first + second;
    Console.Write($" {num}");
    first = second;
    second = num;
}
*/


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] array = GetArray(10, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] result = CopyArr(array);
Console.WriteLine($"Копия массива: [{String.Join(", ", result)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int[] CopyArr(int[] ar)
{
    int[] ar2 = new int[ar.Length];
    for (int i = 0; i < ar.Length; i++)
    {
        ar2[i] = ar[i];
    }
    return ar2;
}