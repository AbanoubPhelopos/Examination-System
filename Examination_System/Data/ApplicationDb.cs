using Examination_System.User;

namespace Examination_System.Data;

public static class ApplicationDb
{
    public static List<Subject>? Subjects { get; set; }
    public static readonly List<User.User> Users = new List<User.User>
    {
        new Student("Abanoub", "Pop", "123"),
        new Admin("Phelps", "pop", "12"),
    };
    
    
}