// Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя)
// 5-25
// 3-9 и т.д.


Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

int sqrt = number * number;

Console.WriteLine("Квадрат числа =" + sqrt);