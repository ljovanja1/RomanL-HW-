// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int dep = Convert.ToInt32(Console.ReadLine());


int[,,] array3D = new int[rows, col, dep];
// GetMatrix(rows, col, dep);
// PrintMatrix(GetMatrix(rows, col, dep));
PrintMatrix(GetMatrix(array3D));

void PrintMatrix(int[,,] matrix)
{
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
        } 
    }
}
// int[,,] GetMatrix(int rows, int col, int dep) 
int[,,] GetMatrix(int[,,] matrix) 
{
    // int[,,] matrix = new int[rows, col, dep];
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                 matrix[i,j,k] = random.Next(10, 100);
            }
        }
    }
    return matrix;
}