using System;
using System.IO;

namespace Task1;

public class MainProgram
{
    public static void Main()
    {
        var path = Directory.GetCurrentDirectory();
        const string menuPanel = "\n\t--help                      | Call this menu" +
                                 "\n\tcd <path>                   | Move between directories" +
                                 "\n\t-o <(file/dir)_name>        | Open dir/file and show content (Name is optional)" +
                                 "\n\t-c <(file/dir)_name> <path> | Copy dir/file to another path (Another path is optional)" +
                                 "\n\t-m <(file/dir)_name> <path> | Move dir/file to another path" +
                                 "\n\t-rm <(file/dir)_name>       | Remove dir/file" +
                                 "\n\t-i <(file/dir)_name>        | Get info about dir/file by name (Name is optional)" +
                                 "\n\texit                        | Exit from program" +
                                 "\n";

        Console.WriteLine(menuPanel);
        while (true)
        {
            Console.Write(path + ">");
            var command = Console.ReadLine();
            if (command != null)
            {
                var parser = new CommandParser(command);
                var parameters = parser.Parse();
                string? toPath;
                
                var elementName = parameters["value"];
                var newPath = WorkingWithDirectory.GetNewPath(elementName);
                var allPaths = elementName?.Split(" ");
                switch (parameters["type"])
                {
                    case "--help":
                        Console.WriteLine(menuPanel);
                        break;
                    case "cd":
                        toPath = parameters["value"];
                        WorkingWithDirectory.NewPath(path);
                        WorkingWithDirectory.ChangePath(toPath);
                        path = WorkingWithDirectory.GetPath();
                        break;
                    case "-o":
                        Console.WriteLine("");
                        if (File.Exists(newPath))
                        {
                            var fileContent = WorkingWithFiles.GetLines(elementName);
                            if (fileContent != null)
                                foreach (var line in fileContent)
                                {
                                    Console.WriteLine("\t" + line);
                                }
                        }
                        else if (Directory.Exists(newPath))
                        {
                            var subDirectories = WorkingWithDirectory.GetDirs(elementName);
                            var files = WorkingWithDirectory.GetFiles(elementName);
                            if (subDirectories != null)
                                foreach (var subDirectory in subDirectories)
                                {
                                    Console.WriteLine("\t<DIR>  | " + subDirectory?.Replace(newPath + @"\", "") + @"\");
                                }

                            if (files != null)
                                foreach (var file in files)
                                {
                                    Console.WriteLine("\t<FILE> | " + file?.Replace(newPath + @"\", ""));
                                }
                        }
                        Console.WriteLine("");
                        break;
                    case "-c":
                        if (File.Exists(WorkingWithDirectory.GetNewPath(allPaths?[0])))
                        {
                            Console.WriteLine("File");
                            WorkingWithFiles.Copy(allPaths?[0], allPaths?[1]);
                        }
                        else if (Directory.Exists(WorkingWithDirectory.GetNewPath(allPaths?[0])))
                        {
                            Console.WriteLine("Dir");
                            WorkingWithDirectory.Copy(allPaths?[0], allPaths?[1]);
                        }
                        Console.WriteLine("Copy");
                        break;
                    case "-m":
                        if (File.Exists(WorkingWithDirectory.GetNewPath(allPaths?[0])))
                        {
                            WorkingWithFiles.Move(allPaths?[0], allPaths?[1]);
                        }
                        else if (Directory.Exists(WorkingWithDirectory.GetNewPath(allPaths?[0])))
                        {
                            WorkingWithDirectory.Move(allPaths?[0], allPaths?[1]);
                        }
                        break;
                    case "-rm":
                        if (File.Exists(newPath))
                        {
                            File.Delete(newPath);
                        }
                        else if (Directory.Exists(newPath))
                        {
                            Directory.Delete(newPath, true);
                        }
                        break;
                    case "-i":
                        if (File.Exists(newPath))
                        {
                            Console.Write(WorkingWithFiles.GetInfo(elementName) + "\n");
                        }
                        else if (Directory.Exists(newPath))
                        {
                            Console.Write(WorkingWithDirectory.GetInfo(elementName) + "\n");
                        }
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"\n\tCommand \"{parameters["type"]}\" does not exist! Use --help to see more info.\n");
                        break;
                }
            }
        }
    }
}