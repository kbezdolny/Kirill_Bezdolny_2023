namespace InterfaceSegregation.Interfaces;

public interface IAdministrator : IUser
{
    public void WriteToFile(string filename);
    public void GetDataFromFile(string filename);
    public void CopyFile(string filename);
    public void SaveToFile(string filename);
}
