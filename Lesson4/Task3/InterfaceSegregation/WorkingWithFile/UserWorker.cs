using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.WorkingWithFile;

public class UserWorker : RoleChecker, IUser
{
    public string ReadFromFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return "";

        // If the role passed the condition, the file will be read and returned readed data
        return "Data from file";
    }
    public void CheckFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be checked
    }
    public void DownloadFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be downloaded
    }
}
