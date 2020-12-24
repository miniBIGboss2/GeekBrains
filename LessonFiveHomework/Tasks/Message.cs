/*
    Разработать класс Message, содержащий следующие статические методы для обработки текста:
        а) Вывести только те слова сообщения, которые содержат не более n букв.
        б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        в) Найти самое длинное слово сообщения.
        г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        
    Продемонстрируйте работу программы на текстовом файле с вашей программой.
 */

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LessonFiveHomework.Tasks
{
    public class Message
    {
        public static void StartProgram()
        {
            const string filePath = @"C:\Users\miniB\Desktop\Temp\Data.txt";
            const string newFileName = "ProcessedMassage.txt";
            const int lessThanDigit = 4;
            const char lastChar = 'd';
            
            var lastIndexOfChar = filePath.LastIndexOf(@"\");
            var filePathToCreateNewFile = filePath.Remove(lastIndexOfChar) + @"\" + newFileName;
            
            Console.WriteLine("Программа для обработки сообщения пользователя.\n" +
                              "Убедитесь в правильности указанного пути.");

            try
            {
                using (var streamReader = File.OpenText(filePath))
                {
                    var text = streamReader.ReadToEnd();
                    
                    WordsLesserThanN(text, lessThanDigit, filePathToCreateNewFile);
                    DeleteAllStringsWithLastCharN(text, lastChar, filePathToCreateNewFile);
                    FindLongestString(text, filePathToCreateNewFile);
                    StringOfLongestWords(text, filePathToCreateNewFile);
                    
                }
            }
            catch (Exception)
            {
                throw new Exception("Ошибычный путь к файлу.");
            }

            Console.WriteLine("Программа завершила работу. Проверьте новый файл по следущему пути: " +
                              $"{filePathToCreateNewFile}");
        }

        private static void WriteInFile(string filePath, StringBuilder text)
        {
            using (var streamWriter = File.AppendText(filePath))
            {
                streamWriter.WriteLine(text);
            }
        }

        private static void WordsLesserThanN(string text, int n, string newFilePath)
        {
            var inputElements = text.Split(' ');
            var resultBuilder = new StringBuilder();
            
            foreach (var element in inputElements)
            {
                if (element.Length <= n)
                {
                    resultBuilder.Append(element + " ");
                }
            }
            
            WriteInFile(newFilePath, resultBuilder);
        }

        private static void DeleteAllStringsWithLastCharN(string text, char n, string newFilePath)
        {
            var inputElements = text.Split(' ');
            var resultBuilder = new StringBuilder();

            foreach (var element in inputElements)
            {
                if (element.Last() != n)
                {
                    resultBuilder.Append(element + " ");
                }
            }
            
            WriteInFile(newFilePath, resultBuilder);
        }

        private static void FindLongestString(string text, string newFilePath)
        {
            var inputElements = text.Split(' ');
            
            var resultBuilder = new StringBuilder();
            resultBuilder.Append(inputElements.OrderByDescending(s => s.Length).First());
            
            WriteInFile(newFilePath, resultBuilder);
        }

        private static void StringOfLongestWords(string text, string newFilePath)
        {
            var inputElements = text.Split(' ');
            Array.Sort(inputElements, (x, y) => y.Length.CompareTo(x.Length));
            var resultBuilder = new StringBuilder();

            for (var i = 0; i < 3; i++)
            {
                resultBuilder.Append(inputElements[i] + " ");
            }
            
            WriteInFile(newFilePath, resultBuilder);
        }
    }
}