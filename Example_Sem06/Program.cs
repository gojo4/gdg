// Задача 40: Напишите программу, 
// которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Введите первое число: ");
// int value1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int value2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int value3 = Convert.ToInt32(Console.ReadLine());

// if (value1 < (value2 + value3) && (value2 < (value1 + value3))&&(value3 < (value1 + value2)))
// {
//     Console.WriteLine("Треугольник существует");
// }
// else if((value1 <= 0) || (value2 <= 0) || (value3 <= 0))
// {
//     Console.WriteLine("Некорректный ввод");
// }
// else
// {
//      Console.WriteLine("Треугольник не существует");
// }

//Задача 40. Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());

// string str = "";

// while (value > 0)
// {
//     str = value % 2 + str;
//     value = value / 2;
// }
// int temp = Convert.ToInt32(str);
// temp++;
// Console.WriteLine(temp);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число больше 2");
// int N = Convert.ToInt32(Console.ReadLine());
// int i=2;
// if (N>=i)
// {
//     int[] fib=new int[N];
//     fib[0]=0;
//     fib[1]=1;
//     Console.Write($"{fib[0]} {fib[1] }");//Console.Write("0 1");
// while(i<N) //for(int i=2;i<N;i++)
// {
//     fib[i]=fib[i-1]+fib[i-2];
//     Console.Write($" {fib[i]}");
//     i++;
// }
// }
// else{
//     Console.WriteLine("Некорректный ввод");
// }

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[5]{1,2,3,4,5};

// int temp=0;
// for (int i = 0; i < array.Length/2; i++)
// {
//     temp = array[i];
//     array[i]=array[array.Length-1-i];
//     array[array.Length-1-i]=temp;
// }

// Console.WriteLine(String.Join(",",array));

