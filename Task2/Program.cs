/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке
от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNum(int numM, int numN)
{
    if (numM == numN + 1) return 0;
    return numM + SumNum(numM + 1, numN);
}

int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = GetNum("Введите число M: ");
int n = GetNum("Введите число N: ");

Console.Write($"M = {m}; N = {n} -> {SumNum(m, n)}");
