// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходепоказывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int randomNumber = new Random().Next(100, 1000);
int firstDigit = randomNumber / 100;
int secondDigit = randomNumber % 100 / 10;
int thirdDigit = randomNumber % 10;
Console.WriteLine($"Первая цифра: {firstDigit}; Вторая цифра {secondDigit}; третья: {thirdDigit}");
Console.WriteLine(secondDigit);