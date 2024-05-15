using DesignPatterns.ChainOfResponsibility.PasswordValidator;
using DesignPatterns.ChainOfResponsibility.PasswordValidator.handlers;

var password = "ciao";
var passwordHandler = ClientHandler.GetPasswordHandler();

try
{
    var info = passwordHandler.Validate(password);
    Utilities.PrintResult(password, info);
}
catch (Exception)
{
    Console.WriteLine("Info nullo");
}