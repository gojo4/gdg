/*Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа.*/

int value = new Random().Next(10,100);
Console.WriteLine(value);

int a = value / 10;
int b = value % 10;
Console.WriteLine("Наибольшее число:");
if (a>b)
    {
        Console.WriteLine(a);
    }
else if (a < b)
    {
        Console.WriteLine(b);
    }
else
    {
        Console.WriteLine("Числа равны");
    }