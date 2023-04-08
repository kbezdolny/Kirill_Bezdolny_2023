namespace InterfaceSegregation.Interfaces;

public interface IRole
{
    public Guid? CheckUser(Guid user);
    public Guid? CheckRole(Guid role);
}
