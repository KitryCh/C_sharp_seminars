// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ProductionToOne(int number)
{
    var production = 1;
    if(number < 0)
    production = 0;
    else
    {
    for(int i = number; i > 1; i--)
         production *= i;   
    }
    return production;
}
Console.Write("Введите число: ");
var num = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение всех цифр: {ProductionToOne(num)}.");