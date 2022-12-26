// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.

// void NumbersFromMtoN(int m, int n)
// {
// if (n > m) NumbersFromMtoN(m, n - 1);
// Console.Write($"{n} ");
// if (m > n) NumbersFromMtoN(m, n + 1);
// }
// NumbersFromMtoN(10, 1);

// Вариант Даниила

// string Numbers(int m, int n)
// {
//     if(n == m)
//     return $"{n}";

//     return $"{n} {Numbers(m, n + 1)}";
// }
// Console.WriteLine(Numbers(7, 1));

// Еще один вариант Даниила

string Numbers(int m, int n)
{
    if(n == m)
    return $"{n}";

    return (n < m) ? $"{n} {Numbers(m, n + 1)}" : $"{Numbers(m, n - 1)} {n}";
}
Console.WriteLine(Numbers(2, 7));