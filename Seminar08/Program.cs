// **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] firstArray = FillArray(rows, columns, 0, 10);
PrintArray(firstArray);
 SortArray(firstArray);
 Console.WriteLine("===========================================");
 PrintArray(firstArray);



int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for(int j=0; j< array.GetLength(1);j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(1)-1, j];
        array[array.GetLength(1)-1, j] = temp;
    }
}
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] firstArray = FillArray(rows, columns, 0, 10);
PrintArray(firstArray);
Console.WriteLine("===========================================");

if (firstArray.GetLength(0) == firstArray.GetLength(1))
{
int[,] secondArray = ChangeArray(firstArray);
PrintArray(secondArray);
}
else
{
    Console.WriteLine("Матрица не квадратная!");
}

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[j, i] = array[i, j];
        }
    }
    return array2;
}
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] firstArray = FillArray(rows, columns, 0, 10);
PrintArray(firstArray);
Console.WriteLine("===========================================");
int [,] thirdArray = ArrayDell(firstArray);
PrintArray(thirdArray);


int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ArrayDell(int[,] array){
    int numbeMin = array[0,0];
    int num1=0 , num2 =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++){
            if (numbeMin>array[i,j])
            { 
                numbeMin=array[i,j];
                num1=i ;
                num2 = j;
            }
        }
    }
    int [,] array2 = new int[array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i = 0 , x = 0 ; i < array.GetLength(0); x++, i++)
    {
        if ( i== num1) {
            x--;
            continue;
        }
        for (int j = 0 , y = 0; j < array.GetLength(1); y++, j++){
            if ( j== num2) {
            y--;
            continue;
            }
            array2[x,y]=array[i,j];
        }
    }
    return array2;
}
