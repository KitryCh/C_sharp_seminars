// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел = {GetSumNums(a)}");


// Console.Write("Введите число: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел = {GetSumNums(b)}");


// Console.Write("Введите число: ");
// int c = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел = {GetSumNums(c)}");


// int GetSumNums(int number)
// {
// int sum = 0;
// while (number > 0)
// {
// //Console.Write($"{number} ");
// sum += number;
// number--;
// }
// return sum;
// } 

// или

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");


int GetSumNums(int number)
{
int sum = 0;
while (number > 0)
{
Console.Write($"{number} ");
sum += number;
number--;
}
return sum;
} 