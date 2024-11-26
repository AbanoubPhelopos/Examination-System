using Examination_System.User;

namespace Examination_System;

public static class ApplicationUi
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
        }
    }

    private static void Login()
    {
        Console.Clear();
        Console.Write("Please enter your username: ");
        string? username = Console.ReadLine();
        Console.Write("Please enter your password: ");
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

        Console.WriteLine();
        IdentityManager.Login(username, password);
    }
    
}