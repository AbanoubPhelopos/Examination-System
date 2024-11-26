using Examination_System.UI;

namespace Examination_System.User;

public class Admin : User
{
    public Admin(string name,string userName,string password):base(name,userName,password)
    {
        base.Role = "Admin";
    }

    public override void RoleBaseUi()
    {
        AdminUi.AdminMenu(this);
    }
}