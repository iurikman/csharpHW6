/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else 
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int[] GetArray(int minValue, int maxValue, int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {

        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int [] ArrayCopy(int [] array)
{
    int [] arrayCopy = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(" ");
}

int minValue = GetNumber("Введите минимальное число массива");
int maxValue = GetNumber("Введите максимальное число массива");
int length = GetNumber("Введите длину массива");
int [] array = GetArray(minValue, maxValue, length);
Console.WriteLine("Исходный массив:");

PrintArray(array);
Console.WriteLine(" ");
int[] arrayCopy = ArrayCopy(array);
Console.WriteLine(" ");
Console.WriteLine("Новый массив:");
PrintArray(arrayCopy);
