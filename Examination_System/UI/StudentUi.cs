using Examination_System.User;

namespace Examination_System.UI;

public static class StudentUi
{
    public static void StudentMenu(Student user)
    {
        Console.WriteLine($"Welcome {user.Name}");
    }
}