using Examination_System.Data;
using Examination_System.User;

namespace Examination_System.UI;

public static class IdentityUi
{
    public static void StartPoint()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Examination System");
        Console.WriteLine("1) Login\n2) Register\n3) Exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Login();
                break;
            case 2:
                Register();
                break;
            case 3:
                return;
            default:
                Console.WriteLine("Invalid choice");
                StartPoint();
                break;
        }
    }

    private static void Login()
    {
        Console.Clear();
        Console.Write("Username: ");
        string? username = Console.ReadLine();
        Console.Write("Password: ");
        string password = ReadPassword();
        Console.WriteLine();
        IdentityManager.Login(username, password);
    }

    private static void Register()
    {
        Console.Clear();
        Console.Write("Name : ");
        string? name = Console.ReadLine();
        Console.Write("Username: ");
        string? username = Console.ReadLine();
        Console.Write("Password: ");
        string password = ReadPassword();
        User.User user = new Student(name, username, password);
        ApplicationDb.Users.Add(user);
        StartPoint();
    }

    private static string ReadPassword()
    {
        string password = string.Empty;
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                Console.Write("\b \b");
                password = password[0..^1];
            }
            else if (!char.IsControl(key.KeyChar))
            {
                Console.Write("*");
                password += key.KeyChar;
            }
        }
        while (key.Key != ConsoleKey.Enter);

        return password;
    }
    
}