// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" | {array[i, j]} | ");
        Console.WriteLine();
    }
}

int[] FindMinIndex(int[,] array)
{
    int minValue = array[0, 0];
    int[] minIndex = new int[2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minIndex[0] = i;
                minIndex[1] = j;
                minValue = array[i, j];
            }
        }
    }
    return minIndex;
}

int[,] DeleteCrossroad(int[,] array)
{
    int[] minIndex = FindMinIndex(array);
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int newI = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int newJ = 0;
        if (i != minIndex[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (j != minIndex[1])
                {
                    newArray[newI, newJ] = array[i, j];
                    newJ++;
                }
            newI++;
        }
    }

    return newArray;
}


int[,] array = CreateArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine(String.Join(", ", FindMinIndex(array)));
Console.WriteLine();
PrintArray(DeleteCrossroad(array));