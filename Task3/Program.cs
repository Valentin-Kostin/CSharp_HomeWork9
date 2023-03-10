/*Задача 68: Напишите программу вычисления
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumFromUser(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numbM = GetNumFromUser("Введите число M:");
int numbN = GetNumFromUser("Введите число N:");

///Метод вычисления функции Аккермана:
int AckermannFunction(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
    return AckermannFunction(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел A({numbM},{numbN}) = {AckermannFunction(numbM, numbN)}");