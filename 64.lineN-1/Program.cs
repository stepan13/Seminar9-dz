// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine(GetNumbers(10));

string GetNumbers(int start, int end = 1)
{
    if (start == end)
        return start.ToString();
    else
        return (start + " " + GetNumbers(--start));
}