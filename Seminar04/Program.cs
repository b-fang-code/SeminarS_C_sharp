// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.

// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от 1 до {A} будет равна {GetSum(A)}");

// // -----------------------------МЕТОДЫ------------------------------
// int GetSum(int limit)
// {
//     int sum = 0;
//     for (int i = 1; i <= limit; i++)
//     {
//         sum = sum + i;  // sum +=i
//     }
//     return sum;
// }






//// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3         // 78 -> 2           // 89126 -> 5


// Console.Write("ВВедите число : ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine ($"Число цифр в числе {A} = {GetSum(A)}");

// //  ----------- Методы --------------
// int GetSum(int limit)
// {
//     int dlina = Convert.ToInt32(Math.Log10(limit))+1;
//     return dlina;
// } 



/////   Вариант перебора
// Console.WriteLine("Введите число: ");
// int Num = int.Parse(Console.ReadLine()!);
// int GetSize(int Number)
// {
//     int i = 10;
//     int size = 1;
//     while(true){
//         if(Number / i != 0)
//         {
//             size += 1;
//         }
//         else
//         {
//             break;
//         }
//         i *= 10;
//     }
//     return(size);
// }
// Console.WriteLine(GetSize(Num)); 


/// Ещё один вариант 

// Console.WriteLine("Введи число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Знаков - {GetLength(number)} ");


// // Metod

// int GetLength(int num){
//     int c = 0;
//     while(num > 0){
//     c++;
//     num = num / 10;
//     }
//     return c;
// }




//////// ВАРИАНТ СОФЬИ///////

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Количество цифр = {GetCountNum(num)}");

// int GetCountNum(int number)
// {
//     int count = 0;
//     while(number>0)
//     {
//         count ++;
//         number/=10;
//     }
//     return count;
// }










///// Задача 30:   Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.   [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// Mass(array);
// Console.WriteLine($"Массив:  {String.Join("  ", array)}");

// int[] Mass(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);  //  ...Next (от 0 до 2-х, не включая 2)
//     }
//     return array;
// }



///////////// ВАРИАНТ СОФЬИ////////
// int [] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join("," , array)}]");

// int [] GetBinaryArray(int size)
// {
//     int [] result = new int[size];
//     for (int i = 0; i<size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }





/// Задача 28: Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива – 10.
/// Заполнение массива осуществить случайными числами от 50 до 100.

int[] arr= array(10);
Console.WriteLine($"Массив [{String.Join(", ",arr)}]");

Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение элементов меньше {Num} следующее {arrayPr(arr, Num)}");

int[] array(int number){  // Заполнение массива
    int[] array1= new int[number];
     for(int i=0; i<array1.Length; i++)
     {
        array1[i] = new Random().Next(50,101);
    }
    return array1;
}
int arrayPr(int[] array, int number)
{  // Произведение элементов
    int Proizv=1;
     for(int i=0; i<array.Length; i++)
     {
        if (array[i]<number)
        {
            Proizv=Proizv*array[i];
        }
       }
    return Proizv;
}