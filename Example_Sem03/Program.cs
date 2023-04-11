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