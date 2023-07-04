// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введиете 1 число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиете 2 число ");
int y = Convert.ToInt32(Console.ReadLine());
double d = 0;
for (int i = 1; i < 10; i++)
{
   d = (Math.Pow(x, y));
   Console.WriteLine($"Число {x} в степени {y} = {d}");
}