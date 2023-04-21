// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] arrayNum = new int [12];
// int positivNum = 0;
// int negNum = 0;

// for (int i = 0; i < arrayNum.Length; i++)
// {
//     arrayNum[i] = new Random().Next(-9,10);
//     if (arrayNum[i] > 0)
//     {
//         positivNum += arrayNum[i];
//     }
//     else
//     {
//         negNum += arrayNum[i];
//     }
// }
// Console.WriteLine(String.Join(",", arrayNum)
// +"\nСумма положительных: " + positivNum + "\nСумма отрицательных: " + negNum);

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.WriteLine("Введите элементы массива: ");
// int [] arrayNum = new int [5];
// int value = -1;

// for (int i = 0; i < arrayNum.Length; i++)
// {
//     arrayNum[i] = Convert.ToInt32(Console.ReadLine());
    
// }
// Console.WriteLine("[" + String.Join(", ", arrayNum) + "]");

// for (int i = 0; i < arrayNum.Length; i++)
// {
//     arrayNum[i] = arrayNum[i] * value;
// }
// Console.WriteLine("[" + String.Join(", ", arrayNum) + "]");

// int[] numArr = new int[] {1,7898,66,-6,-52,0};

// Console.WriteLine(String.Join(",",numArr));

// for(int i=0;i<numArr.Length;i++)
// {
//     numArr[i]=-numArr[i];
// }

// Console.WriteLine(String.Join(",",numArr));

// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите элементы массива: ");
// int [] arrayNum = new int [5];
// bool flag = false;
// for (int i = 0; i < arrayNum.Length; i++)
// {
//     arrayNum[i] = Convert.ToInt32(Console.ReadLine());
    
// }
// Console.WriteLine("[" + String.Join(", ", arrayNum) + "]");
// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < arrayNum.Length; i++)
// {
//     if (arrayNum[i] == value)
//     {
//         flag = true;
//         break;
//     }
// }

// if (flag==true)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
 
// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int [] arrayNum = new int[123];
// int num = 0;

// for (int i = 0; i < arrayNum.Length; i++)
// {
//     arrayNum[i] = new Random().Next(0,501);

//     if ((arrayNum[i] > 9)&&(arrayNum[i] < 100))
//     {
//         num++;
//     }
// }

// Console.WriteLine("[" + String.Join(", ", arrayNum) + "]");
// Console.WriteLine("Количество двухзначных чилел: " + num);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arrayNum1 = new int [] {3,8,2,6,5};
int[] arrayNum2 = new int [arrayNum1.Length/2 + arrayNum1.Length%2];

for (int i = 0; i < arrayNum2.Length; i++)
{
    arrayNum2[i] = arrayNum1[i]*arrayNum1[arrayNum1.Length-1-i];

    if (i == arrayNum1.Length-1-i)
    {
        arrayNum2[i] = arrayNum1[arrayNum1.Length-1-i];
    }
}
Console.WriteLine("[" + String.Join(", ", arrayNum1) + "]");
Console.WriteLine("[" + String.Join(", ", arrayNum2) + "]");

// int[] arr = new int[5] {3,8,2,6,5}; //первый массив
// int lg = arr.Length;                //задаем переменную для длинны первого массива для простоты формул
// int middle = lg/2 + lg%2;           //узнаем длину второго массива(четный или нет)
// int[] arr2 = new int[middle];       //задаем длину второго массива

// for(int i=0;i<middle;i++)
// {
//     arr2[i]=arr[i]*arr[lg-i-1];  //берем пары элементов(1 и последний, 2й и предпоследний...) и перемножаем

//     if(i==lg-1-i)               //если массив не четный
//     {
//         arr2[i]=arr[lg-1-i];    //то записать центральный элемент в конец второго массива
//     }
// }
// Console.WriteLine(String.Join(",",arr2)); // выводим второй массив через запятую