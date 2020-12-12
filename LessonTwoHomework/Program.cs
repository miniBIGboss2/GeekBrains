using System;
using LessonTwoHomework.Tasks;

// Костяков Дмитрий

namespace LessonTwoHomework
{
    internal class Program
    {
        public static void Main()
        {
            // TaskOne.FindMinNumb(); //Задание №1

            // TaskTwo.HowManyDigitsInNumbers(); //Задание №2
            
            var taskThree = new SumOfOddPositiveNumbers(); //Задание №3
            taskThree.StartProgram();

            // TaskFour.AuthorizeUser(); //Задание №4
            
            // TaskFive.GiveAdviceAboutWeight(); //Задание №5
            
            TaskSix.CalculateAmountOfGoodNumbers(); //Задание №6

            Console.ReadKey();
        }
    }
}