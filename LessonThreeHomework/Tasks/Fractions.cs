using System;

namespace LessonThreeHomework.Tasks
{
    public class Fractions
    {
        private int _numerator;
        private int _denominator;
        private bool _fractionPrint;

        private int Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }

        private int Denominator
        {
            get => _denominator;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }

                _denominator = value;
            }
        }

        private bool FractionPrint1
        {
            get => _fractionPrint;
            set => _fractionPrint = value;
        }

        public Fractions() { }

        public Fractions(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fractions(int numerator, int denominator, bool fractionPrint)
        {
            Numerator = numerator;
            Denominator = denominator;
            FractionPrint1 = fractionPrint;
        }

        public static Fractions FractionsAddition(Fractions fractionOne, Fractions fractionTwo, bool print)
        {
            var tempFraction = new Fractions();
            
            if (fractionOne._denominator == fractionTwo._denominator)
            {
                tempFraction._numerator= fractionOne._numerator + fractionTwo._numerator;
                
                tempFraction._denominator = fractionOne._denominator;
            }
            else
            {
                tempFraction._numerator = fractionOne._numerator * fractionTwo._denominator +
                                           fractionTwo._numerator * fractionOne._denominator;
                
                tempFraction._denominator = fractionOne._denominator * fractionTwo._denominator;
            }

            if (print)
            {
                Console.Write("Сумма дробей: ");
                FractionPrint(tempFraction);
            }

            return tempFraction;
        }

        public static Fractions FractionsSubtraction(Fractions fractionOne, Fractions fractionTwo, bool print)
        {
            var tempFraction = new Fractions();
        
            if (fractionOne._denominator == fractionTwo._denominator)
            {
                tempFraction._numerator = fractionOne._numerator - fractionTwo._numerator;

                tempFraction._denominator = fractionOne._denominator;
            }
            else
            {
                tempFraction._numerator = fractionOne._numerator * fractionTwo._denominator -
                                          fractionTwo._numerator * fractionOne._denominator;
                
                tempFraction._denominator = fractionOne._denominator * fractionTwo._denominator;
            }

            if (print)
            {

                Console.Write("Разность дробей: ");
                FractionPrint(tempFraction);
            }

            return tempFraction;
        }

        public static Fractions FractionsMultiplication(Fractions fractionOne, Fractions fractionTwo, bool print)
        {
            var tempFraction = new Fractions();
            
            tempFraction._numerator = fractionOne._numerator * fractionTwo._numerator;

            tempFraction._denominator = fractionOne._denominator * fractionTwo._denominator;
            
            if (print)
            {

                Console.Write("Произведение дробей: ");
                FractionPrint(tempFraction);
            }

            return tempFraction;
        }

        public static Fractions FractionsDivision(Fractions fractionOne, Fractions fractionTwo, bool print)
        {
            var tempFraction = new Fractions();

            tempFraction._numerator = fractionOne._numerator * fractionTwo._denominator;

            tempFraction._denominator = fractionOne._denominator * fractionTwo._numerator;
            
            if (print)
            {

                Console.Write("Частное дробей: ");
                FractionPrint(tempFraction);
            }

            return tempFraction;
        }

        public static void FractionPrint(Fractions input)
        {
            var commonDivisor = FindGreatestCommonDivisor(input._numerator, input._denominator);
            
            input._numerator /= commonDivisor;
            input._denominator /= commonDivisor;
            
            Console.WriteLine($@"{input._numerator} \ {input._denominator}");
        }

        private static int FindGreatestCommonDivisor(int a, int b) => 
            (a == 0) ? b : FindGreatestCommonDivisor(b % a, a);
    }
}