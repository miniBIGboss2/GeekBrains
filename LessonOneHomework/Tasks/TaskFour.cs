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
        public static void SwapVariablesValue(int x, int y)
        {
            Console.Write(x + " ");
            Console.WriteLine(y);
            
            // var temp = x;
            // x = y;
            // y = temp;

            x += y;
            y = x - y;
            x -= y;
            
            Console.Write(x + " ");
            Console.WriteLine(y);
        }
    }
}