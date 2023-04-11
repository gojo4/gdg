/* Напишите программу, которая выводит случайное 
трехзначное число и удаляет вторую цифру этого числа.*/
/*
// 456 -> 46
// 782 -> 72
// 918 -> 98
int num =new Random().Next(100,1000); 
Console.WriteLine(num);

int a = num / 100;
int b = num % 10;
// int c = (num % 100) / 10;

Console.WriteLine("Итоговое число " + a + b);
// Console.WriteLine($"Итоговое число {a}{b}");
// Console.WriteLine($"Итоговое число {c}");
*/


/*
Console.WriteLine ("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;

if( result == 0){
    Console.WriteLine ("Число 2 кратно числу 1");
}
else{
    Console.WriteLine ("Число 2 не кратно числу 1 отстаток " + result);
}
*/

/*Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да */
/*
int value = new Random().Next(100,1000);
//int value = 161;
Console.WriteLine(value);

if ((value%7 == 0) && (value%23 == 0))
    {
        Console.WriteLine("Да");
    }
else
    {
        Console.WriteLine("Нет");
    }
    */


//Напишите программу, которая принимает на вход два числа 
//и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.WriteLine("Введите число");
int value1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int value2=Convert.ToInt32(Console.ReadLine());

//double m = Math.Pow(a,2);
if(value1 == value2*value2)
    {
        Console.WriteLine("Число 1 является квадратом числа 2");
    }
else
    {
        Console.WriteLine("Число 1 не является квадратом числа 2");
    }