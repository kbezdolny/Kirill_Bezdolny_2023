namespace InterfaceSegregation.Interfaces;

public interface IOwner : IAdministrator
{
    public void DeleteFile(string filename);
}
