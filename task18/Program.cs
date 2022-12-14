// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray(uint size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void PrintArray(int[] array)
{
    foreach(int element in array)
    Console.Write($"{element}, ");
    Console.WriteLine();
}

int[] ChangesSings(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = - array[i];
    return array;
}

int[] array = CreateArray(5, -9, 9);
PrintArray(array);
array = ChangesSings(array);
PrintArray(array);