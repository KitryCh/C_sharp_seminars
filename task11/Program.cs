// Задача 18: Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Write("Введите номер четверти ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine($"x и y могут быть от 0 до {Int32.MaxValue}");
}
if (quarter == 2)
{
    Console.WriteLine($"x может быть от 0 до {Int32.MinValue}, может быть от 0 до {Int32.MaxValue}");
}
if (quarter == 3)
{
    Console.WriteLine($"x и y могут быть от 0 до {Int32.MinValue}");
}
if (quarter == 4)
{
    Console.WriteLine($"x может быть от 0 до {Int32.MaxValue}, может быть от 0 до {Int32.MinValue}");
}