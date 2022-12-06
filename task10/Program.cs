// Задача № 17: Напишите программу, которая принимает на вход координаты точки X и Y, причём X не равен 0, и Y не равен 0, и выдаёт номер 
// четверти, в которой находится эта точка.

Console.Write("Введите координату точки: X =");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите координату точки: Y =");
int Y = int.Parse(Console.ReadLine());

if(X > 0 && Y > 0) Console.WriteLine("1");
if(X < 0 && Y > 0) Console.WriteLine("2");
if(X < 0 && Y < 0) Console.WriteLine("3");
if(X > 0 && Y < 0) Console.WriteLine("4");