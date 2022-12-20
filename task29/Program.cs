// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if(i %2 == 0 && j %2 ==0)
            array[i, j] *= array[i, j];
            return array;
}

int[,] array = CreateArray(7, 7, 0, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);
