// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Degree(int a, int b)
// {
// if (b == 0) return 1;
// else return a * Degree(a, b - 1);
// }
// Console.WriteLine("Введите число a: ");
// int n = Math.Abs(int.Parse(Console.ReadLine()!));
// Console.WriteLine("Введите число b: ");
// int m = Math.Abs(int.Parse(Console.ReadLine()!));
// Console.WriteLine(Degree(n, m));

// Вариант Даниила

// int Pow(int number, int pow)
// {
//     if (pow == 1)
//     return number;

//     return number * Pow(number, pow - 1);
// }
// Console.WriteLine(Pow(3, 5));

// Ещё один вариант Даниила
int Pow(int number, int pow)
{
    return pow == 1 ? number : number * Pow(number, pow - 1);
}
Console.WriteLine(Pow(3, 5));