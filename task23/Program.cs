// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertToBinary(int number)
{
    var binary = String.Empty;
    while(number > 0)
    {
        binary = Convert.ToString(number%2) + binary;
        number /= 2;
    }
    return binary;
}

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Двоичное число: {ConvertToBinary(number)}.");