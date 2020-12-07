/*
    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonTwoHomework.Tasks
{
    public class SumOfOddPositiveNumbers
    {
        public readonly List<double> ListOfNumbers = new List<double>();
        
        public void StartProgram()
        {
            Console.WriteLine("Программа находит сумму всех нечетных положительных чисел \n" +
                              "введеных пользователем с консоли пока не будет введен ноль.");

            
            double sumOfNumbers;
            
            try
            {
                sumOfNumbers = GetSum();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.GetType().Name}.");
                throw;
            }

            Console.WriteLine($"Сумма всех нечетных положительных чисел равна: {sumOfNumbers}.");
        }
        
        private double GetSum() => AddNumber(ListOfNumbers).Where(i => i % 2 != 0 && i > 0).Sum();

        private List<double> AddNumber(List<double> list)
        {
            bool flag;
            double number;

            do
            {
                var userInput = Console.ReadLine();
                flag = double.TryParse(userInput, out number);

                if (!flag)
                {
                    Console.WriteLine($"'{userInput}' не является числом.\nПожалуйста,в видите число.");
                }
                else
                {
                    list.Add(number);
                }
            } while (number != 0 || !flag);

            return list;
        }
    }
}