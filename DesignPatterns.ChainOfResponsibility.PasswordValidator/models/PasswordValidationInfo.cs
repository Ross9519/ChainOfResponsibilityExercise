namespace DesignPatterns.ChainOfResponsibility.PasswordValidator.models
{
    internal class PasswordValidationInfo
    {
        public List<string> ErrorMessages { get; set; } = [];

        public void PrintErrors()
        {
            if (ErrorMessages.Any())
                ErrorMessages.ForEach(m => Console.WriteLine(m));
            else
                Console.WriteLine("Nessun errore");
        }
    }
}
