//Костяков Дмитрий

using System;
using LessonFourHomework.Tasks;

namespace LessonFourHomework
{
    internal class Program
    {
        public static void Main()
        {
            // DivisiblePairs.StartProgram(); //Задание №1
            
            // LoginPasswordInArray.StartProgram(); //Задание №3

            var sum = 0; //Задание №4
            
            var array = new TwoDimensionalArray(10,10);
            
            array.SumOfNumbers(out sum);
            Console.WriteLine(sum);


            Console.ReadKey();

        }
    }
}