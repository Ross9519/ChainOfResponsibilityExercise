using DesignPatterns.ChainOfResponsibility.PasswordValidator.models;

namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers
{
    internal class SpecialCharHandler : Handler
    {
        private const string _regexString = ".*[^\\w\\s]|_.*";
        private const string _errorMessage = "La password deve contenere almeno un carattere speciale";

        public override PasswordValidationInfo? Validate(string password, PasswordValidationInfo? info)
        {
            return base.Validate(password, PatternMatch(password, info, _regexString, _errorMessage));
        }
    }
}
