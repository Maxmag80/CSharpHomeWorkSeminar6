// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
//Пример:*
//для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
Console.WriteLine("Input Fibonacci sequence number: ");
int k = Convert.ToInt32(Console.ReadLine());
int size = k * 2 - 1;
int[] array = new int[size];
int zeroIndex = (size / 2);

Fibonacci(array);
PrintArray(array);

void Fibonacci(int[] array)
{
    array[zeroIndex] = 0;
    array[zeroIndex - 1] = 1;
    array[zeroIndex + 1] = 1;
    int j = zeroIndex - 2;

    while (j >= 0)
    {
        array[j] = array[j + 2] - array[j + 1];
        j--;
    }
    for(int i = zeroIndex + 2; i < size ; i++)
    {
        array[i] = array[i-1]+array[i-2];
        array[i] = array[i-1]+array[i-2];
    }
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
