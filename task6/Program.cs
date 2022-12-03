// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98

int number = new Random() .Next(100, 1000);
int firstNumber = number/100;
int thirdNumber = number%10;

Console.WriteLine($"Случайное число = {number}");
Console.WriteLine($"Получается {firstNumber * 10 + thirdNumber}");