using DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers;

var password = "CiaoPippo_29";

var passwordHandler = ClientHandler.GetPasswordHandler();

try
{
    var info = passwordHandler.Validate(password);

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
catch (Exception)
{
    Console.WriteLine("Info nullo");
}