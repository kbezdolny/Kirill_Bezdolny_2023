using System.IO;
using System;

namespace Task1;

public static class WorkingWithDirectory
{
    private static string? _path { get; set; }

    public static void NewPath(string? path)
    {
        _path = path;
    }
    
    public static string? GetPath()
    {
        return _path;
    }

    public static string? Parent()
    {
        return Path.GetDirectoryName(_path);
    }

    public static string? GetNewPath(string? dirName)
    {
        string path;
        if (dirName is not null)
        {
            if (Path.IsPathRooted(dirName))
            {
                path = dirName;
            }
            else
            {
                var newPath = _path + @"\" + dirName.Replace("/", @"\");
                path = newPath;
            }
        }
        else
        {
            if (_path is null) return null;
            path = _path;
        }
        
        return path;
    }
    
    public static void ChangePath(string? inputPath)
    {
        if (inputPath is null) return;
        
        inputPath = inputPath.Replace("/", @"\");
        if (Path.IsPathRooted(inputPath))
        {
            _path = inputPath;
            return;
        }
        var paths = inputPath.Split(@"\");
        foreach (var p in paths)
        {
            try
            {
                if (p == "") continue;
                _path = p.Substring(0, 2) == ".."
                    ? Parent()
                    : _path + @"\" + p.Replace(@"\", "");
            }
            catch
            {
                Console.WriteLine(_path + $">Path \"{p}\" does not exist!");
                break;
            }
        }
    }

    public static string[]? GetDirs(string? dirName)
    {
        var path = GetNewPath(dirName);
        return path is null ? null : Directory.GetDirectories(path);
    }
    
    public static string[]? GetFiles(string? dirName)
    {
        var path = GetNewPath(dirName);
        return path is null ? null : Directory.GetFiles(path);
    }
    
    public static void Copy(string? dirName, string? toPath=null)
    {
        if (dirName is null) return;
        var path = GetNewPath(dirName);
        if (path is null) return;
        if (toPath is null)
        {
            toPath = GetPath() + @"\" + dirName;
        }
        else
        {
            if (Path.IsPathRooted(dirName))
            {
                toPath = GetNewPath(toPath) + @"\" + new DirectoryInfo(dirName).Name;
            }
            else
            {
                toPath = GetNewPath(toPath) + @"\" + dirName;
            }
        }
        
        DirectoryInfo dir = new DirectoryInfo(path);
        if (!dir.Exists) return;
        DirectoryInfo[] dirs = dir.GetDirectories();
        if (!Directory.Exists(toPath))
        {
            Directory.CreateDirectory(toPath);
        }
        FileInfo[] files = dir.GetFiles();
        foreach (FileInfo file in files)
        {
            file.CopyTo(Path.Combine(toPath, file.Name), true);
        }
        foreach (DirectoryInfo subdir in dirs)
        {
            Copy(Path.Combine(path, subdir.Name), toPath);
        }
    }
    
    public static void Move(string? dirName, string? toPath)
    {
        if (toPath is null || dirName is null) return;
        var path = GetNewPath(dirName);
        toPath = GetNewPath(toPath) + @"\" + dirName;
        if (path is null) return;
        
        Directory.Move(path, toPath);
    }

    public static string? GetInfo(string? dirName)
    {
        var path = GetNewPath(dirName);
        if (path is null) return null;
        
        var directoryInfo = new DirectoryInfo(path);
        if (!directoryInfo.Exists) return $"\nThe directory \"{dirName}\" does not exist.\n";
        
        var resultInfo = "";
        resultInfo += "\n\t<Directory name>   | " + directoryInfo.Name;
        resultInfo += "\n\t<Full path>        | " + directoryInfo.FullName;
        resultInfo += "\n\t<Creation time>    | " + directoryInfo.CreationTime;
        resultInfo += "\n\t<Last access time> | " + directoryInfo.LastAccessTime;
        resultInfo += "\n\t<Last write time>  | " + directoryInfo.LastWriteTime;
        resultInfo += "\n";
        return resultInfo;
    }
}