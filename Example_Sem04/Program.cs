// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int count = 0;

// int GetSum()
// {
//     while (value > count)
//     {
//         count++;
//         sum += count;
//     }
//     return sum;
// }

// Console.WriteLine(GetSum());


// Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// // 456 -> 3
// // 78 -> 2
// // 89126 -> 5
// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// int count=0;

// int GetNumCount()
// {
//     while(value != 0)
//         {
//             value /= 10;
//             count++;
//         }
//     return count;
// }

// Console.WriteLine(GetNumCount());

// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// int temp = 1;

// for (int i = 1; i <= value; i++)
//     {
//         temp *= i;
//     }
// Console.WriteLine(temp);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arrayNum = new int[8];

// for (int i = 0; i < arrayNum.Length; i++)
//     {
//         arrayNum[i] = new Random().Next(0,2);
//         Console.Write(arrayNum[i] + ",");
//     }

// for (int i = 0; i < arrayNum.Length; i++)
//     {
//     arrayNum[i] = new Random().Next(0,2);
//     }

// Console.WriteLine(arrayNum.Length);
// // Console.WriteLine(String.Join(", " , arrayNum));


// int [] arrayNum = new int [8];

// for (int i = 0; i < arrayNum.Length; i++)
// {
//     arrayNum[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(String.Join(", ", arrayNum));

