// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 10;
int[] array = new int[size];

int Negative = 0;

for (int i = 0; i < size; i++) 
{
    array[i] = new Random().Next(100, 999);
    if (array[i] % 2 == 0)
    { 
        Negative++;
        Console.WriteLine($"Число {array[i]} - четное");
    }
    else
    {
    Console.WriteLine($"Число {array[i]} - нечетное");        
    }
}
Console.WriteLine($"Четных чисел в массиве всего = {Negative}");