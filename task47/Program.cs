// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array2D = GetMatrix(rows, columns);
PrintMatrix(array2D);

double[,] GetMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(-10, 11)*0.1, 1);
        }
    }
    return matrix;
}
void PrintMatrix (double[,] matrix)
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