using ConsoleApp1.Models;
using System.Reflection;
namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        var propID = typeof(User).GetProperty("Id", System.Reflection.BindingFlags.NonPublic
    | System.Reflection.BindingFlags.Instance);
        propID.SetValue(user, 3);
        Console.WriteLine(propID.GetValue(user));
        var propName = typeof(User).GetProperty("Name", System.Reflection.BindingFlags.NonPublic
    | System.Reflection.BindingFlags.Instance);
        propName.SetValue(user, "Nihad");
        Console.WriteLine(propName.GetValue(user));
        User.ChangeAge(20);
        User.PrintAge();
    }
}