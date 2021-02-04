/*
    1) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. 
        Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, 
        свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
        возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
        
    2) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    
    3) Обработать возможные исключительные ситуации при работе с файлами.
 */

using System;

namespace LessonFourHomework.Tasks
{
    public class TwoDimensionalArray
    {
        public int[,] Array;
        
        public TwoDimensionalArray(int xIndex, int yIndex)
        {
            var randomNumb = new Random();

            for (var x = 0; x < xIndex; x++)
            {
                for (var y = 0; y < yIndex; y++)
                {
                    Array[x, y] = randomNumb.Next(101);
                }
            }
        }
        
        public void SumOfNumbers(out int sum)
        {
            sum = 0;
            for (var x = 0; x < Array.GetLength(0); x++)
            {
                for (var y = 0; y < Array.GetLength(1); y++)
                {
                    sum += Array[x, y];
                }
            }
        }
        
        public int SumNumbersGreaterThan(int sum, int min)
        {
            for (var x = 0; x < Array.GetLength(0); x++)
            {
                for (var y = 0; y < Array.GetLength(1); y++)
                {
                    if(Array[x, y] > min)
                        sum += Array[x, y];
                }
            }

            return sum;
        }
        
        public int Max
        {
            get
            {
                int max = Array[0, 0];
                for (int i = 0; i < Array.GetLength(0); i++)
                for (int j = 0; j < Array.GetLength(1); j++)
                    if (Array[i, j] > max) max = Array[i, j];

                return max;
            }
        }
    }
}