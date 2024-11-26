using Examination_System.Data;

namespace Examination_System.User;

public abstract class User
{
    
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }=string.Empty;

    protected User(string name, string userName, string password)
    {
        Name = name;
        Password = password;
        UserName = userName;
    }

    public abstract void RoleBaseUi();
}