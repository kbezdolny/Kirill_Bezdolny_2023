namespace InterfaceSegregation; 
using LiskovSubstitution;

public class WorkingWithFile : IWorkingWithFile
{
    public Guid? CheckUser(Guid user)
    {
        // Checking user in system...
        // If user in system, this method returned user
        // Else returned empty user
        return null;  
    }

    public Guid? CheckRole(Guid role)
    {
        Guid? user = CheckUser(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (user is null) return null;
        
        // If user is exist in system, this method returned role of this user!
        // Else returned empty user
        return user;
    }

    public string ReadFromFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return "";

        // If the role passed the condition, the file will be read and returned readed data
        return "Data from file";
    }

    public void WriteToFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, in file will be write data from argument "filedata"
    }

    public void DeleteFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be deleted
    }

    public void DownloadFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be downloaded
    }
    public void CopyFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be copyed
    }
    public void GetDataFromFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, we will get data from file
    }
    public void CheckFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be checked
    }
    public void SaveToFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be saved
    }
}
