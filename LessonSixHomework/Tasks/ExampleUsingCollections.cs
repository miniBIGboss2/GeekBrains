/*
    Переделать программу «Пример использования коллекций» для решения следующих задач:
        а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        б) Подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
        в) Отсортировать список по возрасту студента;
        г)  Отсортировать список по курсу и возрасту студента;
        д) Разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата 
            и методов предикатов.
*/

using System;
using System.Collections.Generic;
using System.IO;

namespace LessonSixHomework.Tasks
{
    public static class ExampleUsingCollections
    {
        private static int MyDelegate(Student st1, Student st2) => string.Compare(st1.firstName, st2.firstName);

        public static void StartProgram()
        {
            var bachelor = 0;
            var master = 0;
            
            var list = new List<Student>(); // Создаем список студентов
            
            var dt = DateTime.Now;
            
            var sr = new StreamReader("students_6.csv");
            
            while (!sr.EndOfStream)
            {
                try
                {
                    var s = sr.ReadLine()?.Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    
                    if (s == null) continue;
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]),
                        int.Parse(s[7]), s[8]));
                    
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[5]) < 5) bachelor++;
                    else master++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }

            sr.Close();
            list.Sort(MyDelegate);
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", master);
            Console.WriteLine("Бакалавров:{0}", bachelor);
            foreach (var v in list) Console.WriteLine(v.firstName);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}