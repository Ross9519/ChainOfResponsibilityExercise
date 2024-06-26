﻿using DesignPatterns.ChainOfResponsibility.PasswordValidator.models;

namespace DesignPatterns.ChainOfResponsibility.PasswordValidator
{
    internal static class Utilities
    {
        public static string CharNoRegex = ".{8,}";
        public static string CharNoError = "La password deve essere lunga almeno 8 caratteri";

        public static string NumNoRegex = "^(?:.*?\\d){2}";
        public static string NumNoError = "La password deve contenere almeno 2 numeri";

        public static string MaiuscRegex = "[A-Z]";
        public static string MaiuscError = "La password deve contenere almeno una lettera maiuscola";

        public static string SpecialCharRegex = ".*[^\\w\\s]|_.*";
        public static string SpecialCharError = "La password deve contenere almeno un carattere speciale";

        public static void PrintResult(string password, PasswordValidationInfo? info)
        {
            if (!info.ErrorMessages.Any())
                Console.WriteLine($"Password [{password}] is valid");
            else
            {
                Console.WriteLine($"Password [{password}] is invalid");
                Console.WriteLine();
                Console.WriteLine("List of errors:");
                info?.PrintErrors();
            }
        }
    }
}
