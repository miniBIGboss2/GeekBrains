/*
    Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 
        включительно. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых 
        хотя бы одно число делится на 3. 
        
    В данной задаче под парой подразумевается два подряд идущих элемента массива. 
        Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
 */

using System;
using System.Linq;

namespace LessonFourHomework.Tasks
{
    public static class DivisiblePairs
    {
        public static void StartProgram()
        {
            const int rangeMin = -10000;
            const int rangeMax = 10000;
            const int divisibleBy = 3;
            const int arraySize = 20;
            
            var countOfPairs = 0;
            var randomNumberFromRange = new Random();

            var array = Enumerable.Repeat(0, arraySize)
                .Select(i => randomNumberFromRange.Next(rangeMin, rangeMax)).ToArray();
            

            for (var i = 0; i < array.Length -1; i++)
            {
                if (array[i]%divisibleBy == 0 || array[i+1]%divisibleBy==0)
                {
                    countOfPairs += 1;
                }
            }

            Console.WriteLine($"Кол-во пар в массиве: {countOfPairs}.");
            Console.WriteLine("Массив состоит из следующих чисел:");
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
        }
        
    }
}