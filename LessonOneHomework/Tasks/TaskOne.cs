/*
    Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
    а) используя склеивание;
    б) используя форматированный вывод;
    в) *используя вывод со знаком $.
 */

using System;

namespace LessonOneHomework.Tasks
{
   public static class TaskOne
    {
        public static void FillForm()
        {
            Console.WriteLine("Заполните анкету отвечая на следующие вопросы:");
            
            var firstName = GetFirstName();
            var lastName = GetLastName();
            var age = GetAge();
            var height = GetHeight();
            var weight = GetWeight();
            
            //Сцепка строк
            //var output = "Ваши данные - 1)Имя: " + lastName + " " + firstName + " 2)Возраст: " + age + " 3)Рост и вес: " + height + "см" + " и " + weight+ "кг.";
            //Console.WriteLine(output);
            
            //Составное форматирование 
            //var output = string.Format("Ваши данные - 1)Имя: {0} {1} 2)Возраст: {2} 3)Рост и вес: {3}см и {4}кг.", lastName, firstName, age, height, weight);
            //Console.WriteLine(output);
            
            //Интерполяция строк
            Console.WriteLine($"Ваши данные - 1)Имя: {lastName} {firstName} 2)Возраст: {age} 3)Рост и вес: {height}см и {weight}кг.");
        }

        private static string GetFirstName()
        {
            Console.Write("Как вас зовут: ");
            return Console.ReadLine();
        }

        private static string GetLastName()
        {
            Console.Write("Какая у вас фамилия: ");
            return Console.ReadLine();
        }

        private static int GetAge()
        {
            Console.Write("Сколько вам лет: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static double GetHeight()
        {
            Console.Write("Какой у вас рост: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double GetWeight()
        {
            Console.Write("Какой у вас вес: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}