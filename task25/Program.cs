// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i=0; i<array.Length; i++)
        newArray[i] = array[i];
        return newArray;
}
int[] array = {1, 4, 7, 5, 8, 30, 3};
int[] copyOfArray = CopyArray(array);

Console.WriteLine(String.Join("|", copyOfArray));