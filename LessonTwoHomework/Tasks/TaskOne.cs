/*
    Написать метод, возвращающий минимальное из трех чисел.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonTwoHomework.Tasks
{
    public static class TaskOne
    {
        public static void FindMinNumb()
        {
            Console.Write("Программа находит минимально число из предложенных.\n" + 
                              "Впишите все числа через пробел: ");
            
            Console.WriteLine($"Минимальное число: {GetNumbersFromConsole().Min()}");
        }
        
        private static IEnumerable<int> GetNumbersFromConsole() =>
            Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
    }
}