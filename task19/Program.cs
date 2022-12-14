// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
bool FindNumber(int findNumber, int[] array)
{
    bool isInArray = false;
    foreach(int element in array)
    {
        if(element == findNumber)
        {
            isInArray = true;
            break;
        }
    }
    return isInArray;
}

int[] array = CreateArray(10, 1, 15);
PrintArray(array);

Console.Write("введите число для поиска в массиве: ");
var numberToFind = Convert.ToInt32(Console.ReadLine());

if(FindNumber(numberToFind, array))
Console.Write("Такое число есть.");

else
Console.Write("Такого числа нет.");