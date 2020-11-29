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
        public static void Questionary()
        {
            string firstName;
            string lastName;
            int age;
            double height;
            double weight;
            
            Console.WriteLine("Запонлите анкету отвечая на следующие вопросы:");
            Console.Write("Как вас зовут: ");
            firstName = Console.ReadLine();
            Console.Write("Какая у вас фамилия: ");
            lastName = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой у вас рост: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Какой у вас вес: ");
            weight = Convert.ToDouble(Console.ReadLine());
            
            //Сцепка строк
            //var output = "Ваши данные - 1)Имя: " + lastName + " " + firstName + " 2)Возраст: " + age + " 3)Рост и вес: " + height + "см" + " и " + weight+ "кг.";
            //Console.WriteLine(output);
            
            //Составное форматирование 
            //var output = string.Format("Ваши данные - 1)Имя: {0} {1} 2)Возраст: {2} 3)Рост и вес: {3}см и {4}кг.", lastName, firstName, age, height, weight);
            //Console.WriteLine(output);
            
            //Интерполяция строк
            Console.WriteLine($"Ваши данные - 1)Имя: {lastName} {firstName} 2)Возраст: {age} 3)Рост и вес: {height}см и {weight}кг.");
        }
    }
}