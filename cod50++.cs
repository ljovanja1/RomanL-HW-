int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size]; // Массив на size элементов
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }

    return result; // Массив, который заполнили числами в диапазоне от min до max
}
// Массив на 7 элементов, каждый элемент - число от 0 до 10 (рандомное)
int[] array = GetArray(7, 0, 10); // size = 10, min = 0, max = 10
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// true - число в массиве есть, false - числа нет

int numberForSearch = 10;
// bool found = false; // Число не найдено - false, true - найдено
string result = "не найден";
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == numberForSearch)
    {
        result = "найден";
    }
}
Console.WriteLine($"Элемент {numberForSearch} в массиве: {result}");
// if (found) // found == true 
// {
//     Console.WriteLine($"Число {numberForSearch} в массиве присутствует ");
// }
// else
// {
//     Console.WriteLine($"Число {numberForSearch} в массиве отсуствует ");
// }