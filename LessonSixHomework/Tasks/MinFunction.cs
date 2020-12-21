/*
    Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
    
    Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 */

using System;
using System.IO;

namespace LessonSixHomework.Tasks
{
    public static class MinFunction
    {
        public static void StartProgram()
        {
            Func<double, double, double> delegate1 = CustomFuncOne;
            SaveFunc("data.bin", -100, 0,100, delegate1);
            Console.WriteLine(Load("data.bin"));

            Func<double, double, double> delegate2 = CustomFuncTwo;
            SaveFunc("data.bin", 3, -2,100, delegate2);
            Console.WriteLine(Load("data.bin"));

            Func<double, double, double> delegate3 = Sinus;
            SaveFunc("data.bin", -100, 100,100, delegate3);
            Console.WriteLine(Load("data.bin"));
        }
        
        private static void SaveFunc(string fileName, double x, double a, double endOfRange, Func<double, double, double> function)
        {
            var step = 0.5;
            
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            using (var bw = new BinaryWriter(fs))
                while (x <= endOfRange)
                {
                    bw.Write(function(x, a));
                    x += step;
                }
        }

        private static double CustomFuncOne(double x, double a) => x * x - 50 * x + 10;

        private static double CustomFuncTwo(double x, double a) => a * x * x;

        private static double Sinus(double x, double a) => a * Math.Sin(x);

        private static double Load(string fileName)
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