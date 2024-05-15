namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers
{
    internal static class ClientHandler
    {
        public static Handler GetPasswordHandler()
        {
            var passwordHandler = new CharNoHandler();

            passwordHandler
                .SetNext(new NumNoHandler())
                .SetNext(new MaiuscHandler())
                .SetNext(new SpecialCharHandler());

            return passwordHandler;
        }
    }
}
