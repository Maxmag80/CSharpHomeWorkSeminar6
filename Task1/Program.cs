//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 5
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("specify the total quantity of input integer numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for(int i = 0; i < size; i++)
    {
        if(i == 0)
            Console.WriteLine("input first number: ");
        else if(i == size - 1)
            Console.WriteLine("input last number: ");
        else 
            Console.WriteLine("input next number: ");
        
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for(int j = 0; j < size; j++)
        Console.Write($"{array[j]}  ");
}

for(int k = 0; k < size; k++)
{
    if(array[k] > 0)
    count++;
}
Console.WriteLine();
Console.WriteLine($"the quantity of positive numbers = {count}");
