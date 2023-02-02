//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GetRandomArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] cloneArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        cloneArray[i] = array[i];
    }
    return cloneArray;
}

Console.Clear();
int[] array = GetRandomArray(10, 0 , 10);
int[] cloneArray = CopyArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(string.Join(" ", cloneArray));