namespace ConsoleApp1.Exceptions;

internal class InvalidPhoneFormat:Exception
{
    public InvalidPhoneFormat(string message) : base(message)
    {

    }
}
