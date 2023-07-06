// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int randomNumber = new Random().Next(1, 100000000);
Console.WriteLine(randomNumber);
    for (int i = 0; i < randomNumber; i++)
    {
        int x1 = randomNumber / 1000000000;
        int x2 = randomNumber % 1000000000 / 100000000;
        int x3 = randomNumber % 100000000 / 10000000;
        int x4 = randomNumber % 10000000 / 1000000;
        int x5 = randomNumber % 1000000 / 100000;
        int x6 = randomNumber % 100000 / 10000;
        int x7 = randomNumber % 10000 / 1000;
        int x8 = randomNumber % 1000 / 100;
        int x9 = randomNumber % 100 / 10;
        int x10 = randomNumber % 10;
        int sum = x1 + x2 +x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10;
        // Console.WriteLine($"{x1} + {x2} + {x3} + {x4} + {x5} + {x6} + {x7} + {x8} + {x9} + {x10} = {sum}");
        Console.WriteLine($"В числе {randomNumber} суммa цифр = {sum}");
        break;
    }


    // 