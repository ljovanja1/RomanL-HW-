// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int randomNumber = new Random().Next(1, 10900);
Console.WriteLine(randomNumber);
    for (int i = 0; i < randomNumber; i++)
    {
        int firstDigit = randomNumber / 1000;
        int secondDigit = randomNumber  % 1000 / 100;
        int thirdDigit = randomNumber  % 100 / 10;
        int fourthDigit = randomNumber % 10;
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine($"{firstDigit} + {secondDigit} + {thirdDigit} + {fourthDigit} = {sum}");
        break;
    }