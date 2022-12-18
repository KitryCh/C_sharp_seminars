// Задача 44: Не используя рекурсию, введитепервые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

int[] Fibonacci(int number)
{
    int[] array = new int[number];
    for(int i=0; i<number; i++)
    {
        if(i==0)
            array[i] = 0;
        else if (i==1)
            array[i] = 1;
        else
        {
            array[i] = array[i-1] + array[i-2];
        }
    }
    return array;
}
Console.Write("введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(String.Join("|", Fibonacci(number)));