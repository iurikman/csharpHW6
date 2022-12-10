/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

// 1. Функция ввода чисел и подсчета чисел больше 0
// 2. Вызов функции подсчета чисел больше нуля

void GetCountOfPositiveNumbers(string message)
{
    Console.WriteLine(message);

    int countPositiveNumbers = 0;
    int result = 0;
    string printNumbers = "Введенные числа: ";
    string consoleOutput = " ";
    while (consoleOutput != "end")
    {         
        bool isCorrect = false;
        string consoleOut = Console.ReadLine();
        while (!isCorrect)
        {
            if (int.TryParse(consoleOut, out result) || consoleOut == "end")
            {
                isCorrect = true;
            }
            else 
            {
                Console.WriteLine("Ввели не число");
                consoleOut = Console.ReadLine();
            }
        }

        if (result > 0)
        {
            countPositiveNumbers++;  
        }
        consoleOutput = consoleOut;

        if (consoleOut != "end") 
        {
            printNumbers += $"{result}, ";
        }

    }
        Console.WriteLine();
        Console.WriteLine(printNumbers);
        Console.WriteLine();
        Console.WriteLine($"Количество положительных числел: {countPositiveNumbers}");
        Console.WriteLine();
}

GetCountOfPositiveNumbers("Введите числа через enter. В конце ввода введите end ");