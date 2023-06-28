// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Получаем число");
// int result = Convert.ToInt32(Console.ReadLine());


// int randomNuber = new Random().Next(100, 1000);
// int result = randomNuber;
// if (result > 99)
// {
//     int thirdDigit = result % 10;
//     Console.Write($"Получаем число: {result}, третья цифра которого: {thirdDigit}");
// }   
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// // только для 3-хзначных
// 


// Console.Write("Получаем число");
// int number = Convert.ToInt32(Console.ReadLine());
int c = 1; 
int result = 0;
int number = new Random().Next(1, 1000000);

if (number > 99)
{
    while ((number/c) > 99)
    {
        c*=10;
    }
 result = (number % c) / (c/10);
    Console.Write($"Получаем число: {number}, третья цифра которого: {result}");
}   
else
{
    Console.WriteLine("Третьей цифры нет");
}