// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(uint size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
uint CountOfNumbers10To99(int[] array)
{
    uint count = 0;
    foreach(int element in array)
    if(element > 9 && element < 100)
    count++;
    return count;
}

int[] array = CreateArray(123, 0, 1000);
Console.WriteLine(String.Join("," , array));

Console.WriteLine($"В массиве {CountOfNumbers10To99(array)} элементов от 10 до 99.");