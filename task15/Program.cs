﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Получаем  число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 5)
{
    Console.WriteLine($"Число {number}: - выходной");
}
else
{
    Console.WriteLine($"Число {number}: - будни");
}

