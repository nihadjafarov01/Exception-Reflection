using System.Reflection;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.Models;

internal class User
{
    private int Id { get; set; }
    private string Name { get; set; }
    private static int Age { get; set; }

    public static void ChangeAge(int age)
    {
        var propAge = typeof(User).GetProperty("Age", BindingFlags.NonPublic | BindingFlags.Static);
        propAge.SetValue(null, age);
    }
    public static void PrintAge()
    {
        var propAge = typeof(User).GetProperty("Age", BindingFlags.NonPublic | BindingFlags.Static);
        Console.WriteLine(propAge.GetValue(null));
    }
}
