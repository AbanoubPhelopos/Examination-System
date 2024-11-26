namespace Examination_System.UI;

public static class AdminUi
{
    public static void AdminMenu(User.User user)
    {
        Console.WriteLine($"Welcome {user.Name} to Admin menu");
    }
}