// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// 453 -> 12 45 -> 9

// int GetSumNumb(int a)
// {
// if (a > 0) a = a % 10 + GetSumNumb(a / 10);
// return (a);
// }
// Console.WriteLine("Введите число a: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write(GetSumNumb(n));

// Вариант Даниила
// int SumOfNumbers(int number)
// {
//     if(number < 0) number = - number;

//     if(number == 0)
//     return number;
//     return number % 10 + SumOfNumbers(number / 10);
// }

// Console.WriteLine(SumOfNumbers(453));

// Еще один вариант Даниила
int SumOfNumbers(int number)
{
    if (number < 0) number = -number;

    return number == 0 ? number : number % 10 + SumOfNumbers(number / 10);
}

Console.WriteLine(SumOfNumbers(453));