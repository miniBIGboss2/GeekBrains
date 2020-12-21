/*
    Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
    программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 */


using System;

namespace LessonTwoHomework.Tasks
{
    public static class LoginPassword
    {
        private const string UserLogin = "root";
        private const string UserPassword = "GeekBrains";

        public static void AuthorizeUser()
        {

            var attempts = 0;
            const int limitOfAttempts = 3;
            Console.WriteLine("Программа авторизации пользователя.");
            
            do
            {
                Console.Write("Пожалуйста, введите логин: ");
                var userLoginInput = Console.ReadLine();
                
                Console.Write("Пожалуйста, введите пароль: ");
                var userPasswordInput = Console.ReadLine();
                
                if (ValidateUserLoginAndPassword(userLoginInput, userPasswordInput))
                {
                    Console.WriteLine("Авторизация прошла успешно!");
                    break;
                }

                attempts++;
                Console.WriteLine($"Неверная комбинация логин/пароль. Попройте еще раз.\nОсталось попыток: {limitOfAttempts - attempts}.");
            } while (attempts < limitOfAttempts);

            if (attempts == limitOfAttempts)
            {
                Console.WriteLine("Исчерпан лимит на кол-во попыток.Попробуйте в другой раз.");
            }
        }
        
        private static bool ValidateUserLoginAndPassword(string userLoginInput, string userPasswordInput)
        {
            return UserLogin == userLoginInput && UserPassword == userPasswordInput;
        }
    }
}