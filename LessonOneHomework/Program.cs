using System;
using LessonOneHomework.Tasks;

// Костяков Дмитрий

namespace LessonOneHomework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание №1
            TaskOne.FillForm();
            
            //Задание №2 
            TaskTwo.AskWeightAndHeight();

            //Задание №3
            TaskThree.GetVariables();
            
            //Задание №4
            TaskFour.SwapVariablesValue();
            
            //Задание №5
            TaskFive.ShowInfo();
            
            Console.ReadKey();
        }
    }
}

