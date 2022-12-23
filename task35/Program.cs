// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintPascalArrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" | {array[i, j]} | ");
        Console.WriteLine();
    }
}

int[,] PascalTriangle(int rows) 
{ 
    int[,] array = new int[rows, rows]; 
    for (int i = 0; i < rows; i++) 
        array[i, 0] = 1; 
    for (int i = 1; i < rows; i++) 
    { 
        for (int j = 1; j < rows; j++) 
        { 
            array[i, j] = array[i - 1, j] + array[i - 1, j - 1]; 
        } 
    } 
 
    return array; 
} 
 
int[,] array = PascalTriangle(10); 
PrintPascalArrray(array);