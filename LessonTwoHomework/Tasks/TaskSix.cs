/*
    Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
    Хорошим называется число, которое делится на сумму своих цифр.
    Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */

using System;
using System.Linq;

namespace LessonTwoHomework.Tasks
{
    public static class TaskSix
    {
        public static void CalculateAmountOfGoodNumbers()
        {
            var start = DateTime.Now;

            const int startOfRange = 1;
            const int endOfRange = 1000000000;

            var amountOfGoodNumbers = 0;

            Console.WriteLine("Программа подсчета количества хороший чисел.");

            for (var i = startOfRange; i < endOfRange; i++)
            {
                if (IsGoodNumbers(i))
                {
                    amountOfGoodNumbers++;
                }
            }

            Console.WriteLine("Количество хороших чисел в диапазоне от " +
                              $"{startOfRange} до {endOfRange} составило {amountOfGoodNumbers}.");
            
            var finish = DateTime.Now;
            Console.WriteLine($"Время выполнение программы: {finish - start}");
        }

        private static bool IsGoodNumbers (int input)
        {
            var tempName = input;
            var sumOfDigits = 0;

            while (tempName > 0)
            {
                sumOfDigits += tempName % 10;
                tempName /= 10;
            }
            return input % sumOfDigits  == 0;
        }
    }
}