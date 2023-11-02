using ConsoleApp1.Exceptions;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Models;

internal class User
{
    public string _name;
    public string Name 
    {
        get => _name;
        set
        {
            if (value.Length > 30 || value.Length < 3) 
            {
                throw new InvalidNameException("Name length must be between 3 and 30!");
            }
            else
            {
                _name = value;
            }
        }
    }
    public byte _age;
    public byte Age 
    { 
        get => _age;
        set
        {
            if (value <= 0)
            {
                throw new InvalidAgeException("Age sifira beraber veya kicik ola bilmez!");
            }
            else
            {
                _age = value;
            }
        }
    }

    //static string pattern = "^+994 .. ... .. ..$";
    static string pattern = "^a...e$";



    private string _phoneNumber;
    public string PhoneNumber 
    { 

        get => _phoneNumber;
        set
        {
            var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
            if (r.IsMatch(value))
            {
                _phoneNumber = value;
            }
            else
            {
                throw new InvalidPhoneFormat("Phone format is wrong");
            }
            
        }
    }
    private string _password;
    public string Password
    {

        get => _password;
        set
        {
            var a = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (a.IsMatch(value))
            {
                _password = value;
            }
            else
            {
                throw new InvalidPasswordException("Password format is wrong");
            }

        }
    }
}
