// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int count = 0;

int GetSum()
{
    while (value > count)
    {
        count++;
        sum += count;
    }
    return sum;
}

Console.WriteLine(GetSum());