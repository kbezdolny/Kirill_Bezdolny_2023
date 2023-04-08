using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.WorkingWithFile;

public class AdministratorWorker : UserWorker, IAdministrator
{
    public void WriteToFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, in file will be write data from argument "filedata"
    }

    public void GetDataFromFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, we will get data from file
    }

    public void CopyFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be copyed
    }
    public void SaveToFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be saved
    }
}
