// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetMatrix(rows, columns);
PrintMatrix(array); 
int[,] GetMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array [i, j] = Convert.ToInt32(new Random().Next(0,10));
        }
    }
    return array;
}
Console.WriteLine();

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите координаты строки");
int searchRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты столбца");
int searchColumns = Convert.ToInt32(Console.ReadLine());

if (searchRows >= rows && searchColumns >= columns)
{
    Console.WriteLine("такого числа нет");
}
else
{
    object result = array.GetValue(searchRows, searchColumns);
    Console.WriteLine(result);
}


// ПОИСК ЭЛЕМЕНТА
