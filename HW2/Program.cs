// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
int sum = 0;

FillArray(array);

Console.WriteLine("Массив:");
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        sum = sum + array[i];
    }
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sum}");

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
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
