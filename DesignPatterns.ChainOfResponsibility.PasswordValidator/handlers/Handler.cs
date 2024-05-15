using DesignPatterns.ChainOfResponsibility.PasswordValidator.models;
using System.Text.RegularExpressions;

namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers
{
    internal abstract class Handler
    {
        protected Handler? _next;

        public Handler SetNext(Handler next)
        {
            _next = next;
            return _next;
        }


        public virtual PasswordValidationInfo? Validate(string password, PasswordValidationInfo? info = null)
        {
            if (_next is not null)
                return _next?.Validate(password, info);
            else
                return info;
        }

        protected static PasswordValidationInfo PatternMatch(string password, PasswordValidationInfo? info, string regexString, string errorMessage)
        {
            info ??= new PasswordValidationInfo();
            Regex regex = new(regexString);
            if (!regex.IsMatch(password))
                info.ErrorMessages.Add(errorMessage);
            return info;
        }
    }
}
