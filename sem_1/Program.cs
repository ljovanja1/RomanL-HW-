// // Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// int i = 4;
// int sum = i * i;
// Console.Write(sum);

// int i = -3;
// int sum = i * i;
// Console.Write(sum);

// int i = -7;
// int sum = i * i;
// Console.Write(sum);

// Console.WriteLine("Введите номер");

// double number = Convert.ToDouble(Console.ReadLine());

// double result = number * number;

// Console.WriteLine(result);

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());

// // "=" - прис-я; "==" - проверка на равенство
// // firstDigit == secondDigit * secondDigit
// if (firstDigit == secondDigit * secondDigit) // Точка с запятой НИКОГДА перед "{"
// {
//     Console.WriteLine("Число " + firstDigit + " является квадратом от числа " + secondDigit);
// }
// else // Все остальные случаи
// {
//     Console.WriteLine("Число " + firstDigit + " НЕ ЯВЛЯЕТСЯ квадратом от числа " + secondDigit);
// }





// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Введите число: ");

// int N = Convert.ToInt32(Console.ReadLine()); // Перевод строчки в целое число
// if (N < 0) // Число N - отрц.
// {
//     N = N * -1; // N = -5, N = 5
// }
// int negativeN = N * -1; // -N 

// while (negativeN <= N)
// {
//     Console.Write(negativeN + " "); // -n = -2, то печатаю -2
//     negativeN++; // Инкремент: negativeN = negativeN + 1
//     // Декремент: negativeN-- (negativeN = negativeN - 1)
// }


// Console.Write("Введите число: ");

// int N = Convert.ToInt32(Console.ReadLine()); // Перевод строчки в целое число
// if (N < 0) // Число N - отрц.
// {
//     N = N * -1; // N = -5, N = 5
// }
// int negativeN = N * -1; // -N 

// while (negativeN <= N)
// {
//     Console.Write(negativeN + " "); // -n = -2, то печатаю -2
//     negativeN++; // Инкремент: negativeN = negativeN + 1
//     // Декремент: negativeN-- (negativeN = negativeN - 1)
// }