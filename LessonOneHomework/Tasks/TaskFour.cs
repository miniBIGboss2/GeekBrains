/*
    Написать программу обмена значениями двух переменных.
        а) с использованием третьей переменной;
        б) *без использования третьей переменной.
 */

using System;

namespace LessonOneHomework.Tasks
{
    public static class TaskFour
    {
        private static int _x;
        private static int _y;
        
        public static void SwapVariablesValue()
        {
            Console.WriteLine("Программа меняющая значения двух переменных.");
            
            _x = GetX();
            _y = GetY();
            Swap();

            Console.WriteLine($"Теперь Х равен {_x}, а Y равен {_y}.",_x, _y);
        }
        
        private static int GetX()
        {
            Console.Write("Введите значение для X: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int GetY()
        {
            Console.Write("Введите значение для Y: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void Swap()
        {
            // var temp = x;
            // x = y;
            // y = temp;

            _x += _y;
            _y = _x - _y;
            _x -= _y;
        }
    }
}