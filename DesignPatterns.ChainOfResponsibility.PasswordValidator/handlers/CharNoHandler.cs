using DesignPatterns.ChainOfResponsibility.PasswordValidator.models;

namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers
{
    internal class CharNoHandler : Handler
    {
        private const string _regexString = ".{8,}";
        private const string _errorMessage = "La password deve essere lunga almeno 8 caratteri";


        public override PasswordValidationInfo? Validate(string password, PasswordValidationInfo? info)
        {
            return base.Validate(password, PatternMatch(password, info, _regexString, _errorMessage));
        }
    }
}
