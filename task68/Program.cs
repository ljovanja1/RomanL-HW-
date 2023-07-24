﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return GetAkkerman(m - 1, 1);
    }
    else
    {
        return (GetAkkerman(m - 1, GetAkkerman(m, n - 1)));
    }
}
Console.WriteLine($"{m} + {n} = {GetAkkerman(m, n)}");
