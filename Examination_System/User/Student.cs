using Examination_System.UI;

namespace Examination_System.User;

public class Student : User
{
    public List<Subject>? UserSubjects { get; set; } = null;

    public Student(string name , string username, string password):base(name,username,password)
    {
        base.Role = "Student";
    }

    public override void RoleBaseUi()
    {
        StudentUi.StudentMenu(this);
    }
}