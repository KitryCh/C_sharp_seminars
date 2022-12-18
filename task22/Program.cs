// Задача 40: Напигите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольниксо сторонами такой длины.
// Теорема о неравенстве треугольника: каждая стороная меньше суммы двух других сторон.

bool CanBeTriangle(int a, int b, int c)
{
    if(a<b+c && b<a+c && c<a+b)
    return true;
    else
    return false;
}
Console.WriteLine("Введите три числа: ");
var a = Convert.ToInt32(Console.ReadLine());
var b = Convert.ToInt32(Console.ReadLine());
var c = Convert.ToInt32(Console.ReadLine());

if (CanBeTriangle(a, b, c))
Console.WriteLine("Такой треугольник может существовать.");

else
Console.WriteLine("Такого треугольника не может быть.");