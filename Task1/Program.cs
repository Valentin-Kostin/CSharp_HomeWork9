/*Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int PrintNumbers(int num)
{
    if (num == 1) return 0;
    Console.Write(num + ", ");
    PrintNumbers(num - 1);    
    return 1;
}

int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = GetNum("Введите число N: ");

Console.Write($"N = {n} -> ");
Console.Write($"{PrintNumbers(n)}");
