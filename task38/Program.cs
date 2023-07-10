// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double [] array = {3.22, 4.2, 1.15, 77.15, 65.2};

int size = 12;
int[] array = new int[size];

double max = 0;
double min = 0;
double diff = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 999);
    if (array[i] < array[0])
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
    diff = max - min;
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(diff);