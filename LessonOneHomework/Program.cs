using System;
using LessonOneHomework.Tasks;

// Костяков Дмитрий

namespace LessonOneHomework
{
    internal class Program
    {
        public static void Main()
        {
            TaskOne.FillForm(); //Задача №1
            
            TaskTwo.AskWeightAndHeight(); //Задание №2 
            
            TaskThree.GetVariables(); //Задание №3
            
            TaskFour.SwapVariablesValue(); //Задание №4
            
            TaskFive.ShowInfo(); //Задание №5
            
            Console.ReadKey();
        }
    }
}

