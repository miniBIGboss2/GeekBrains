/*
 1) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
    нужно ли человеку похудеть, набрать вес или все в норме;
    
 2) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

using System;
using static LessonOneHomework.Tasks.TaskTwo;

namespace LessonTwoHomework.Tasks
{
    public static class TaskFive
    {
        private const double Underweight = 18.5;
        private const double Overweight = 25;
        private const double AverageBmiOfNormalWeight = 21.7;
        
        public static void GiveAdviceAboutWeight()
        {
            AskWeightAndHeight(); //Метод из второго задание первого урока.

            if (UserBmi <= Underweight)
            {
                Console.WriteLine("У вас недостаточный вес. Вам нужно набрать еще " +
                                  $"{Math.Round(CalculateDifferenceInWeight(UserWeight))}кг.");
            } 
            else if (UserBmi >= Overweight)
            {
                Console.WriteLine("У вас излишний вес. Вам нужно похудеть на " +
                                  $"{Math.Round(CalculateDifferenceInWeight(UserWeight))}кг.");
            }
            else
            {
                Console.WriteLine("У вас нормальный вес.");
            }
        }

        private static double CalculateDifferenceInWeight(double userWeight)
        {
            var usersNormalWeight = CalculateUsersNormalWeight(AverageBmiOfNormalWeight, UserHeight);
            var isUserObese = userWeight > usersNormalWeight;

            return isUserObese ? UserWeight - usersNormalWeight : usersNormalWeight - UserWeight;
        }
        
        private static double CalculateUsersNormalWeight(double averageBmi, double userHeight) => 
            (averageBmi * (userHeight * userHeight) / 10000);
    }
}