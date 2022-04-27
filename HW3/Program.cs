// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];

int diff = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.Write($"Вы ввели массив: "); 
WriteArray(array);
Console.WriteLine();

diff = Max(array) - Min(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {diff}");

int Max(int[] arg)
{
    int resultMax = arg[0];
    for(int i = 1; i < arg.Length; i++)
    {
        if(arg[i] > resultMax)
        {
            resultMax = arg[i];
        }
    }
    return resultMax;
}

int Min(int[] arg)
{
    int resultMin = arg[0];
    for(int i = 1; i < arg.Length; i++)
    {
        if(arg[i] < resultMin)
        {
            resultMin = arg[i];
        }
    }
    return resultMin;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
        Console.Write("[" + array[i] + ", ");
        }
        else if (array.Length - 1 - i == 0)
        {
            Console.Write(array[i] + "]");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine();
}