﻿// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = new int[rows, columns];
// GetArray();
// PrintArray();
// ChangeRows();
// PrintArray();

// void GetArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i, j]);
//         }

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeRows()
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         int temp = result[0, j];
//         result[0, j] = result[result.GetLength(0) - 1, j];
//         result[result.GetLength(0) - 1, j] = temp;
//     }
// }

// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = rows;

// int [,] result = new int [rows,columns];
// int [,] result2 = new int [rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//        {
//         result[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//        {
//         Console.Write(array[i,j]);
//        }

//        Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//        {
//         result2[j,i]=result[i,j];
//        }
//     }
// }

// GetArray();
// PrintArray(result);
// ChangeArray();
// PrintArray(result2);

// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int columns = rows;

int [,] result = new int [rows,columns];

int minEl=int.MaxValue;
int minRows=0;
int minColumns=0;


void GetArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(0,10);

            if (result[i,j]<minEl)
            {
                minEl=result[i,j];
                minRows=i;
                minColumns=j;
            }
        } 
    }
}

void PrintArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
       {
        Console.Write(result[i,j]);
       }

       Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (i!=minRows)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
               if (j!=minColumns)
               {
                Console.Write(result[i,j]);
               }
              
            }

            Console.WriteLine();
        }
        
    }
}

GetArray();
PrintArray();
ChangeArray();
Console.WriteLine(minEl);