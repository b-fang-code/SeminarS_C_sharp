// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9 ]. Найдите сумму отрицательных и положительных элементов массива
/*
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    if (el > 0)
    {
        positiveSum += el;
    }
    else
    {
        negativeSum += el;
    }
}

Console.WriteLine($"Сумма положительных: {positiveSum}, сумма отрицательных: {negativeSum}");

//////////------------ Метод --------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/





////**Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
///[-4, -8, 8, 2] -> [4, 8, -8, -2]
/*
int[] array = new int[] { -4, -8, 8, 2 };
Console.WriteLine($"[{String.Join("," , GetArr(array))}]");

//////////// Method    ////////

int[] GetArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}
*/





// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

/*
int[] arr = new int[] { 6, 7, 19, 345, 3 };
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (numFind(arr, n) == true)
{
    Console.WriteLine($"Число {n} присутствует в массиве");
}
else
{
    Console.WriteLine($"Число {n} НЕ присутствует в массиве");
}

bool numFind(int[] mass, int numb)
{
    foreach (int el in mass)
    {
        if (el == numb)
        {
            return true;
        }
    }
    return false;
}
*/



// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int[] arr = new int[123];
Console.WriteLine($"[{String.Join(",", FillArr(arr))}]");
Console.Write($"Количество элементов равна {Count(arr)}");


int[] FillArr(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 1000);
    }
    return mas;

}

int Count(int[] arr, int n = 9, int m= 100)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el > n && el < m)
        {
            count++;
        }
    }
    return count;
}

