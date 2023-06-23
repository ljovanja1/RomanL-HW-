// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

namespace task8 {

    class Program {

        static void Main() {
        
            Console.Write("Введите число: ");

            int q = Convert.ToInt32(Console.ReadLine());

            for (int B = 1; B <= q; B++) {
            
                if ((B % 2) == 0) {
                    Console.Write(B + " "); 
                }
            }
        }

    }

}