namespace Task1;

public static class WorkingWithFiles
{
    
    public static IEnumerable<string>? GetLines(string? fileName)
    {
        var currentPath = WorkingWithDirectory.GetPath();
        var newPath = currentPath + @"\" + fileName;
        if (!File.Exists(newPath)) return null;
        var fileContent = File.ReadLines(newPath);
        return fileContent;
    }
    
    public static void Copy(string? fileName, string? toPath=null)
    {
        if (fileName is null) return;
        var path = WorkingWithDirectory.GetNewPath(fileName);
        if (toPath is null)
        {
            toPath = WorkingWithDirectory.GetPath() + @"\" + fileName;
        }
        else
        {
            toPath = WorkingWithDirectory.GetNewPath(toPath) + @"\" + fileName;
        }
        if (path is null) return;
        
        File.Copy(path, toPath, true);
    }
    
    public static void Move(string? fileName, string? toPath)
    {
        if (toPath is null || fileName is null) return;
        var path = WorkingWithDirectory.GetNewPath(fileName);
        toPath = WorkingWithDirectory.GetNewPath(toPath) + @"\" + fileName;
        if (path is null) return;
        File.Move(path, toPath);
    }
    
    public static string? GetInfo(string? fileName)
    {
        var path = WorkingWithDirectory.GetNewPath(fileName);
        if (path is null) return null;
        
        var fileInfo = new FileInfo(path);
        if (!fileInfo.Exists) return $"\nThe file \"{fileName}\" does not exist.\n";
        
        var resultInfo = "";
        resultInfo += "\n\t<File name>        | " + fileInfo.Name;
        resultInfo += "\n\t<Full path>        | " + fileInfo.FullName;
        resultInfo += "\n\t<Extension>        | " + fileInfo.Extension;
        resultInfo += "\n\t<File size>        | " + fileInfo.Length + " bytes";
        resultInfo += "\n\t<Creation time>    | " + fileInfo.CreationTime;
        resultInfo += "\n\t<Last access time> | " + fileInfo.LastAccessTime;
        resultInfo += "\n\t<Last write time>  | " + fileInfo.LastWriteTime;
        resultInfo += "\n";
        return resultInfo;
    }
}