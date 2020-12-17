/*
    1) Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы 
        сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные 
        элементы класса.
        
    2) Добавить проверку, чтобы знаменатель не равнялся 0. 
        Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        
    3) Добавить упрощение дробей.
 */

namespace LessonThreeHomework.Tasks
{
    public static class FractionClassTask
    {
        public static void StartProgram()
        {
            var firstFraction = new Fractions(4,5);
            var secondFraction = new Fractions(9,3);

            //var errorFraction = new Fractions(1,0);

            var additionShowcaseOne = Fractions.FractionsAddition(firstFraction, secondFraction, true);

            var subtractionShowcaseOne = Fractions.FractionsSubtraction(firstFraction, secondFraction, true);

            var multiplicationShowcase = Fractions.FractionsMultiplication(firstFraction, secondFraction, true);

            var divisionShowcase = Fractions.FractionsDivision(firstFraction, secondFraction, true);
        }
    }
}