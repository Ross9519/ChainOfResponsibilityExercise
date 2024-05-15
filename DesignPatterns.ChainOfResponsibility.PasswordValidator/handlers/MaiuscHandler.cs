using DesignPatterns.ChainOfResponsibility.PasswordValidator.models;

namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers
{
    internal class MaiuscHandler : Handler
    {
        private const string _regexString = "[A-Z]";
        private const string _errorMessage = "La password deve contenere almeno una lettera maiuscola";

        public override PasswordValidationInfo? Validate(string password, PasswordValidationInfo? info)
        {
            return base.Validate(password, PatternMatch(password, info, _regexString, _errorMessage));
        }
    }
}
