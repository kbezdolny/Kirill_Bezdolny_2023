using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.WorkingWithFile;

public class RoleChecker : IRole
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
}
