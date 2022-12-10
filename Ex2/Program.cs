/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// 1. Функция для ввода числа с провекой.
// 2. Функция нахождения точки пересечения двух прямых.

// 1. Функция для ввода числа с провекой.

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    bool isCorrect = false;
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

// 2. Функция нахождения точки пересечения двух прямых.

void GetCrossPoint(double k1, double b1, double k2, double b2)
{
    Console.WriteLine($"Точка пересечения двух прямых y = {k1} * x + {b1}, y = {k2} * x + {b2} :  ({(b2-b1)/(k1-k2)} , {k1*(b2-b1)/(k1-k2)+b1}).");
}

double k1 = GetNumber("Введите k1");
double b1 = GetNumber("Введите b1");
double k2 = GetNumber("Введите k2");
double b2 = GetNumber("Введите b2");

GetCrossPoint(k1, b1, k2, b2);