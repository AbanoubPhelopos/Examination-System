using System.Threading.Channels;
using Examination_System.Data;

namespace Examination_System.User;

public static class IdentityManager
{
    public static bool Login(string? username, string password)
    {
        User? user = ApplicationDb.Users.FirstOrDefault(u => u.UserName == username);
        if (user is null)
        {
            Console.WriteLine("This account doesn't exist.");
            return false;
        }
        if (username == user.UserName)
        {
            if(password == user.Password)
            {
                Console.WriteLine(user.Role);
                return true;
            }
        }

        Console.WriteLine("Wrong username or password.");
        return false;
    }
}