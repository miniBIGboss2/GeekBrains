/*
    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonTwoHomework.Tasks
{
    public static class TaskThree
    {
        public static void SumOfOddPositiveNumbers()
        {
            Console.WriteLine("Программа находит сумму всех нечетных положительных чисел \n" +
                              "введеных пользователем с консоли пока не будет введен ноль.");

            var sumOfNumbers = 
                AddNumbersFromConsoleToList().Where(i => i % 2 != 0 && i > 0).Sum();
            
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна: {sumOfNumbers}.");
        }

        private static IEnumerable<double> AddNumbersFromConsoleToList()
        {
            double userInput;
            var tempListName = new List<double>();

            do
            {
                userInput = double.Parse(Console.ReadLine());
                tempListName.Add(userInput);
            } while (userInput != 0);

            return tempListName;
        }
    }
}