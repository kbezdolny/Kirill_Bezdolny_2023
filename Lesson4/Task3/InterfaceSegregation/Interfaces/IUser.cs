namespace InterfaceSegregation.Interfaces;

public interface IUser
{
    public string ReadFromFile(string filename);
    public void CheckFile(string filename);
    public void DownloadFile(string filename);
}
