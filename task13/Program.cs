// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int CountOfNumbers(int number)
{
    if(number < 0)
    number = -number;
    var count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
Console.Write("Введите число: ");
var num = int.Parse(Console.ReadLine());

Console.WriteLine($"Количество цифр:{CountOfNumbers(num)}.");
