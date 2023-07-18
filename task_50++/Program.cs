int rows = 3;
int columns = 4;
int[,] array2D = GetMatrix(rows, columns);
PrintMatrix(array2D);
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
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

Console.WriteLine("Введите элемент массива");
int number = Convert.ToInt32(Console.ReadLine());

int[,] SearchMatrixNumber(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine("число есть");
                break;

            }
            else
            {
                Console.WriteLine("такого числа в массиве нет");
                break;
            }
        }
            
    }
    return matrix;
}
Console.WriteLine($"Результат: ");
PrintMatrix(SearchMatrixNumber(array2D));


// можно ли остановить цикл при поиске нужного числа??
// Результат: 
// число есть
// такого числа в массиве нет
// такого числа в массиве нет

// ПОИСК ЧИСЛА А НЕ ЭЛЕМЕНТА