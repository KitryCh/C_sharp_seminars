﻿// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

Console.Write("Введите первое число = ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число = ");
int secondtNumber = int.Parse(Console.ReadLine());

int dev = firstNumber%secondtNumber;

if (dev != 0)
{
    Console.WriteLine($"Остаток от деления - {dev}");
}
else
{
    Console.WriteLine("Кратно");
}