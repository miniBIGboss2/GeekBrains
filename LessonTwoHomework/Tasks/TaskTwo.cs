/*
    Написать метод подсчета количества цифр числа.
 */

using System;

namespace LessonTwoHomework.Tasks
{
    public class TaskTwo
    {
        public static void HowManyDigitsInNumbers()
        {
            Console.Write("Программа находил кол-во цифр в числе.\n"+
                              "Ввидите число: ");
            
            var number = int.Parse(Console.ReadLine());
            

            var digit = FindHowManyDigitsInNumber(number);
            if (digit == 1)
            {
                Console.WriteLine($"В числе {number} {digit} цифра.");
            } else if (digit == 2 ^ digit == 3 ^ digit == 4)
            {
                Console.WriteLine($"В числе {number} {digit} цифры.");
            }
            else
            {
                Console.WriteLine($"В числе {number} {digit} цифр.");  
            }
        }

        private static int FindHowManyDigitsInNumber(int input)
        {
            return (int)Math.Log10(input) + 1;
        }
    }
}