using DesignPatterns.ChainOfResponsibility.PasswordValidator.models;

namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers
{
    internal class CharNoHandler : Handler
    {
        public override PasswordValidationInfo? Validate(string password, PasswordValidationInfo? info)
            => base.Validate(password, PatternMatch(password, info, Utilities.CharNoRegex, Utilities.CharNoError));
    }
}
