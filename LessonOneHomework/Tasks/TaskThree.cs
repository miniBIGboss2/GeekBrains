/*
    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
 */

using System;

namespace LessonOneHomework.Tasks
{
    public static class TaskThree
    {
        public static void GetVariables()
        {
            Console.WriteLine("Программа, которая подсчитывает расстояние между двумя точками.");
            Console.WriteLine("Введите координаты первой точки(x1, y1): ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите координаты второй точки(x2, y2): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            var result = CalculateDistance(x1, x2, y1, y2);
            Console.WriteLine("result = {0:f2}", result);
        }
            
        private static double CalculateDistance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}