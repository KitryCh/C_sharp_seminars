// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" | {array[i, j]} | ");
        Console.WriteLine();
    }
}

int[,] CreateArray(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] array = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
        for (int j = 0; j < sizeN; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int DiagonalSum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    sum += array[i, i];
    return sum;
}
Console.Write("Введите количество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array =CreateArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел по диагонали: {DiagonalSum(array)}.");