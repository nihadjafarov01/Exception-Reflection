using ConsoleApp1.Exceptions;
using ConsoleApp1.Models;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp1;

internal class Program
{

    static void Main(string[] args)
    {
        string name;
        byte age;
        string password;
        string phoneNumber;
        char option = '1';
        User user = new User();
        do
        {
            try
            {
                switch (option)
                {
                    case '1':
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();
                        user.Name = name;
                        option = '2';
                        break;
                    case '2':
                        Console.WriteLine("Enter age: ");
                        age = Convert.ToByte(Console.ReadLine());
                        user.Age = age;
                        option = '3';
                        break;
                    case '3':
                        Console.WriteLine("Enter phone number: ");
                        phoneNumber = Console.ReadLine();
                        user.PhoneNumber = phoneNumber;
                        option = '4';
                        break;
                    case '4':
                        Console.WriteLine("Enter password: ");
                        password = Console.ReadLine();
                        user.Password = password;
                        option = '1'; //proqramdan cixmasini istesek 'q', yeniden baslamasini istesek '1' yaziriq
                        break;
                }
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidPhoneFormat ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        while (option != 'q');
    }
}
