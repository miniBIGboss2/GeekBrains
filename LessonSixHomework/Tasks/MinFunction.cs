/*
    Задание №1
    Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
    Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    
    Задание №2
    Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции 
            и на каком отрезке находить минимум.
        б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
        в) Переделайте функцию Load, чтобы она возвращала массив считанных значений. 
             Пусть она возвращает минимум через параметр.
 */

using System;
using System.IO;

namespace LessonSixHomework.Tasks
{
    public static class MinFunction
    {
        private static double CustomFuncOne(double x, double a) => x * x - 50 * x + 10;
        private static double CustomFuncTwo(double x, double a) => a * x * x;
        private static double Sinus(double x, double a) => a * Math.Sin(x);

        private static readonly Func<double,double,double>[] Functions = {
            CustomFuncOne,
            CustomFuncTwo,
            Sinus
        };
        
        public static void StartProgram()
        {
            try
            {
                var index = Menu();

                Console.Write("Напишите значение с которого начнется отрезок: ");
                var x = GetDouble();

                Console.Write("Напишите значение 'a': ");
                var a = GetDouble();

                Console.Write("Напишите значение на котором закончится отрезок: ");
                var endOfRange = GetDouble();
                
                SaveFunc("data.bin", x, a, endOfRange, Functions[index -1]);
                Console.WriteLine($"Минимальное число на отрезке: {LoadFunc("data.bin")}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        private static double GetDouble() => double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        private static int Menu()
        {
            var numb = 1;

            foreach (var t in Functions)
            {
                Console.WriteLine($"{numb}) {t.Method}");
                numb++;
            }

            Console.Write("Выберите функцию из списка: ");

            return int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        }

        private static void SaveFunc(string fileName, double x, double a, double endOfRange, Func<double,double,double> func)
        {
            var step = 0.5;

            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            using (var bw = new BinaryWriter(fs))
                while (x <= endOfRange)
                {
                    bw.Write(func(x,a));
                    x += step;
                }
        }

        private static double LoadFunc(string fileName)
        {
            var min = double.MaxValue;

            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (var bw = new BinaryReader(fs))
                for (var i = 0; i < fs.Length / sizeof(double); i++)
                {
                    var d = bw.ReadDouble();
                    if (d < min) min = d;
                }

            return min;
        }
    }
}