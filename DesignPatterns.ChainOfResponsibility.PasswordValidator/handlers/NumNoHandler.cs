using DesignPatterns.ChainOfResponsibility.PasswordValidator.models;

namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers
{
    internal class NumNoHandler : Handler
    {
        private const string _regexString = "^(?:.*?\\d){2}";
        private const string _errorMessage = "La password deve contenere almeno 2 numeri";

        public override PasswordValidationInfo? Validate(string password, PasswordValidationInfo? info)
        {
            return base.Validate(password, PatternMatch(password, info, _regexString, _errorMessage));
        }
    }
}
