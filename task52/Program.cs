// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetMatrix(rows, columns);
PrintMatrix(array); 
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] SearchAverage(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        double sumColumns = 0;
        for (int j = 0; j < matrix.GetLength(0); j++) 
        {
            sumColumns += matrix[j, i]; 
        }
        Console.WriteLine($"Сумма элементов в cтолбце {i} = {Math.Round(sumColumns / matrix.GetLength(0), 2)}");
    }
    return matrix;
}
Console.WriteLine("Результат: ");
PrintMatrix(SearchAverage(array));