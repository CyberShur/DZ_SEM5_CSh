// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
int sum = 0;

FillArray(array);

Console.WriteLine("Массив:");
PrintArray(array);


for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        sum ++;
    }
}

Console.WriteLine($"Количество четных значений в массиве равно: {sum}");

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] inputArray)
{
    int count = inputArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{inputArray[position]} ");
        position++;
    }
    Console.WriteLine();
}
