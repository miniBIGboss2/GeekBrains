/*
    а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать 
        сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        
    б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
        При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
 */

using System;
using System.Collections.Generic;
using LessonTwoHomework.Tasks;

namespace LessonThreeHomework.Tasks
{
    public class SumOfOddPositiveNumbersExtention
    {
        public static void StartProgram()
        {
            var task = new SumOfOddPositiveNumbers();
            task.StartProgram(); //Метод из третьего задания второго урока
            
            PrintAllNumbersFromList(task.ListOfNumbers);
        }

        private static void PrintAllNumbersFromList(List<double> input)
        {
            Console.Write("Числа введенные пользователем: ");
            foreach (var i in input)
            {
                Console.Write($"{i} ");
            }
        }
    }
}