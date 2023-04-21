namespace Task1;

public class CommandParser
{
    private string _command { get; }
    public CommandParser(string command)
    {
        _command = command;
    }

    public Dictionary<string, string?> Parse()
    {
        var parameters = _command
            .Trim()
            .Replace("  ", " ")
            .Split(" ");

        return new Dictionary<string, string?>
        {
            {"type", parameters[0]},
            {"value", parameters.Length > 1 ? string.Join(" ", parameters[1..]) : null}
        };
    }
}