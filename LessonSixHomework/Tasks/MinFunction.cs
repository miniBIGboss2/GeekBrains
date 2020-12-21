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
        
        public delegate double Function(double x, double a);
        
        public static void StartProgram()
        {
            SaveFunc("data.bin", -100, 0,100, CustomFuncOne);
            
            Console.WriteLine(Load("data.bin"));
            
            SaveFunc("data.bin", 3, -2,100, CustomFuncTwo);
            
            Console.WriteLine(Load("data.bin"));
            
            SaveFunc("data.bin", -100, 100,100, Sinus);
            
            Console.WriteLine(Load("data.bin"));
        }
        
        private static void SaveFunc(string fileName, double x, double a, double endOfRange, Function function)
        {
            var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            var bw = new BinaryWriter(fs);

            while (x <= endOfRange)
            {
                bw.Write(function(x, a));
                x += 0.5; // x=x+step;
            }

            bw.Close();
            fs.Close();
        }

        private static double CustomFuncOne(double x, double a) => x * x - 50 * x + 10;

        private static double CustomFuncTwo(double x, double a) => a * x * x;

        private static double Sinus(double x, double a) => a * Math.Sin(x);

        private static double Load(string fileName)
        {
            var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var bw = new BinaryReader(fs);
            var min = double.MaxValue;
            double d;
            
            for (var i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                if (d < min) min = d;
            }

            bw.Close();
            fs.Close();
            return min;
        }
    }
}