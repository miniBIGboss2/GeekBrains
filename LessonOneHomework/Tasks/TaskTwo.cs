/*
 * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
 */

using System;

namespace LessonOneHomework.Tasks
{
    public static class TaskTwo
    {
        public static double UserWeight;
        public static double UserHeight;
        public static double UserBmi;
        
        public static void AskWeightAndHeight()
        {
            Console.WriteLine("Программа подсчета вашего индекса массы тела.");

            UserWeight = GetWeight();
            UserHeight = GetHeight();
            UserBmi = CalculateBmi(UserWeight, UserHeight);
            Console.WriteLine($"Ваш ИМТ: {UserBmi}");
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

        private static double CalculateBmi(double weight, double height) => 
            Math.Round((weight / (height * height) * 10000), 2);
    }
}