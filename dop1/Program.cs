// Дополнительное:
// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]

// class Program
// {
//     static void Main(string[] args)
//     {
//         int [] array = {591, 532, 189, 523, 333, 546, 527, 275, 456, 264};
//         for (int i = 0; i < array.Length; i++)
//         {
//             int firstDigit = array[i] / 100;
//             int secondDigit = array[i]  % 100 / 10;
//             int thirdDigit = array[i]  % 10;
//             int sum = firstDigit + secondDigit + thirdDigit;
//             int multiphy = firstDigit * secondDigit * thirdDigit;
//             int X = multiphy / sum;
//             Console.WriteLine($"{firstDigit} + {secondDigit} + {thirdDigit} = {sum}");
//             Console.WriteLine($"{firstDigit} * {secondDigit} * {thirdDigit} = {multiphy}");
//             Console.WriteLine($"{multiphy} / {sum} = {X}");
            
//             if ((multiphy % sum)  == 0)
//             {
//                 Console.WriteLine($"Число {array[i]} интересное");
//             }
//             else
//             {
//                 Console.WriteLine("не интересное");
//             }
//         }
//          Console.ReadLine();

//     }
// }


    int randomNumber = new Random().Next(100, 1000);
        for (int i = 0; i < randomNumber; i++)
        {
            int firstDigit = randomNumber / 100;
            int secondDigit = randomNumber  % 100 / 10;
            int thirdDigit = randomNumber  % 10;
            int sum = firstDigit + secondDigit + thirdDigit;
            int multiphy = firstDigit * secondDigit * thirdDigit;
            int X = multiphy / sum;
            Console.WriteLine($"{firstDigit} + {secondDigit} + {thirdDigit} = {sum}");
            Console.WriteLine($"{firstDigit} * {secondDigit} * {thirdDigit} = {multiphy}");
            Console.WriteLine($"{multiphy} / {sum} = {X}");
            
            if ((multiphy % sum)  == 0)
            {
                Console.WriteLine($"Число {randomNumber} интересное");
                break;
            }
            else
            {
                Console.WriteLine("не интересное");
                break;
            }
        }
         Console.ReadLine();



