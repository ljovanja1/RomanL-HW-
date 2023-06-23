// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
using System;

namespace task4_2 {

    class Program {

        static void Main() {
        
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int third = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (first > second) {
                max = first;
            }
                if (second > first) {
                    max = second;
                }
                    if (third > second) {
                        max = third;
                    }
            else {
                Console.WriteLine("DELETED");
            }
            Console.WriteLine(max);
        }

    }

}