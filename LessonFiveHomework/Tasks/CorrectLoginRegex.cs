/*
    Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 
    символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    
        а) Без использования регулярных выражений;
        б) С использованием регулярных выражений.
 */

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LessonFiveHomework.Tasks
{
    public class CorrectLoginRegex
    {
        public static void StartProgram()
        {
            const string rightLoginText = "Корректный логин.";
            const string wrongLoginText = "Не корректный логин.";
            bool isLoginCorrect;
            
            Console.Write("Программа проверяет логин на корректность.\nВведите свой логин: ");

            var userInput = Console.ReadLine();
            if (userInput == string.Empty) throw new Exception("Значение Логин не может быть пустым.");

            // isLoginCorrect = NotRegexWay(userInput);
            isLoginCorrect = RegexWay(userInput);

            Console.WriteLine(isLoginCorrect ? rightLoginText : wrongLoginText);
        }

        private static bool NotRegexWay(string input)
        {
            if (input == null || input.Length < 2 || input.Length > 10) return false;
            return char.IsLetter(input[0]) && input.All(char.IsLetterOrDigit);
        }

        private static bool RegexWay(string input) => Regex.IsMatch(input, @"^[^0-9\s][a-zA-Z0-9]+$");
    }
}