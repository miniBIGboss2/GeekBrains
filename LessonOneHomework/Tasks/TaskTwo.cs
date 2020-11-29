/*
 * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
 */

using System;

namespace LessonOneHomework.Tasks
{
    public static class TaskTwo
    {
        public static void AskWeightAndHeight()
        {
            Console.WriteLine("Программа подсчета вашего индекса массы тела.");
            
            var weight = GetWeight();
            var height = GetHeight();

            Console.WriteLine("Ваш ИМТ: "+ CalculateBmi(weight, height));
        }

        private static double GetWeight()
        {
            Console.Write("Введите ваш вес: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double GetHeight()
        {
            Console.Write("Введите ваш рост: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static string CalculateBmi(double weight, double height)
        {
            var yourBmi = $"{(float) weight / (height * height) * 10000:0.##}";
            return yourBmi;
        }
    }
}