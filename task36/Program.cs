// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = {3, 7, 23, 12};
int[] array = {-4, -6, 89, 6};
int sumNegative = 0;
for (int i = 1; i < array.Length; i +=2) 
{
    sumNegative = sumNegative + array[i];
}
Console.WriteLine($"сумма нечетных позиций в массиве =  {sumNegative}");