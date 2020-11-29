/*
    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) Сделать задание, только вывод организуйте в центре экрана
    в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
 */


using System;

namespace LessonOneHomework.Tasks
{
    public static class TaskFive
    {
        public static void ShowInfo()
        {
            var fullName = GetInfoName();
            var city = GetInfoCity();
            
            PrintInfo(fullName);
            PrintInfo(city);
        }

        private static string GetInfoName()
        {
            Console.Write("Ваше имя и фамилия: ");
            return Console.ReadLine();
        }

        private static string GetInfoCity()
        {
            Console.Write("Город проживания: ");
            return Console.ReadLine();
        }

        private static void PrintInfo(string info)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (info.Length / 2)) + "}", info);
        }
    }
}