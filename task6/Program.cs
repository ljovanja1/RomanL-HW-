// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using System;

namespace task6 {

    class Program {

        static void Main() {
        
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            if ((first % 2) == 0) {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            
            }
        }

    }

}