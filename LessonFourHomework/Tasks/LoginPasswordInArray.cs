using System;
using System.IO;
using System.Linq;

namespace LessonFourHomework.Tasks
{
    public static class LoginPasswordInArray
    {
        public static void StartProgram()
        {
            Console.WriteLine("Программа переносит комбинацию Логин и Пароль из файла в двумерный массив и сверяет с 'правильной' комбинацией находяшейся в структуре. \n" +
                              "В файле каждую комбинацию Логин и Пароль писать с новой строки через пробел.\n" +
                              "Константа limitOfAttempts ограничивает число проверок. Можно изменить значение на ноль для проверки всех комбинаций.\n" +
                              "Для корректной работы программы убедитесь что путь к файлу верен.");

            const int limitOfAttempts = 3;
            const string filePath = @"C:\Users\miniB\Desktop\Data.txt";
            
            var defaultAccount = new Account("root", "GeekBrains");

            try
            {
                var lineCount = File.ReadLines(filePath).Count();
                var arrayOfLoginsAndPasswords = new string[lineCount, 2];
            
                GetLoginAndPasswordFromFile(arrayOfLoginsAndPasswords, filePath);
            
                TryAuthorizeUser(defaultAccount,arrayOfLoginsAndPasswords,limitOfAttempts,lineCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        private struct Account
        {
            public string UserLogin { get; set; }
            public string UserPassword { get; set; }
            
            public Account(string userLogin, string userPassword)
            {
                UserLogin = userLogin ?? throw new ArgumentNullException();
                UserPassword = userPassword ?? throw new ArgumentNullException();
            }
        }

        private static void GetLoginAndPasswordFromFile(string[,] array, string filePath)
        {
            using (var sr = File.OpenText(filePath))
            {
                string lineInFile;
                var currentLine = 0;
                while ((lineInFile = sr.ReadLine()) != null)
                {
                    var wholeLine = lineInFile.Split(' ');
                    array.SetValue(wholeLine[0],currentLine,0);
                    array.SetValue(wholeLine[1],currentLine,1);
                    currentLine++;
                }
            }
        }

        private static void TryAuthorizeUser(Account account,string[,] array, int limitOfAttempts,int lineCount)
        {
            var attempts = 0;
            
            if (limitOfAttempts == 0)
            {
                do
                {
                    if (ValidateUserLoginAndPassword(account, array, attempts))
                    {
                        Console.WriteLine("Авторизация прошла успешно!");
                        break;
                    }

                    attempts++;
                } while (attempts < lineCount);
                
                if (attempts == lineCount)
                {
                    Console.WriteLine(@"В файле нет правильной комбинации Логин\Пароль.");
                }
            }
            else
            {
                do
                {
                    if (ValidateUserLoginAndPassword(account, array, attempts))
                    {
                        Console.WriteLine("Авторизация прошла успешно!");
                        break;
                    }

                    attempts++;
                } while (attempts < limitOfAttempts);
            
                if (attempts == limitOfAttempts)
                {
                    Console.WriteLine("Исчерпан лимит на кол-во попыток.Попробуйте в другой раз.");
                }
            }
        }

        private static bool ValidateUserLoginAndPassword(Account account, string[,] array, int attempt)
        {
            return account.UserLogin == array[attempt,0] && account.UserPassword == array[attempt,1];
        }
    }
}