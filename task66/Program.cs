// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M ");
double M = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число N ");
double N = Convert.ToDouble(Console.ReadLine());

double SumElements(double start, double end)
{
    if (start == end)  return end;
    return start + SumElements(start + 1, end);
}
if (N < 0)
{
    System.Console.WriteLine("Eсли число N меньше 0: результат не обрабатывается");
    return;
}
Console.WriteLine($"Числа: от {M} до {N}:  Суммa в промежутке = {SumElements(M, N)}");