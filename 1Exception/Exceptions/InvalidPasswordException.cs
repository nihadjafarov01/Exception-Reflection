﻿namespace ConsoleApp1.Exceptions;

internal class InvalidPasswordException:Exception
{
    public InvalidPasswordException(string message) : base(message)
    {

    }
}
