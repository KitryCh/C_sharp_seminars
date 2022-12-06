// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// А (3, 6); В (2, 1) -> 5,09
// А (7, -5); В (1, -1) -> 7,21

Console.Write("Введите координаты первой точки: ");
var x1 = Convert.ToDouble(Console.ReadLine());
var y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки: ");
var x2 = Convert.ToDouble(Console.ReadLine());
var y2 = Convert.ToDouble(Console.ReadLine());

var distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

Console.WriteLine($"Расстояние: {distance}");