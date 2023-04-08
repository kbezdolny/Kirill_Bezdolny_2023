using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.WorkingWithFile;

public class OwnerWorker : AdministratorWorker, IOwner
{
    public void DeleteFile(string filename)
    {
        Guid? role = CheckRole(Guid.Empty);

        // In the condition for full implementation, you need to add a check for the type of role!
        if (role is null) return;
        // If the role passed the condition, the file will be deleted
    }
}
