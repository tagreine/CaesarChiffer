using CaesarChiffer.Interfaces;

namespace CaesarChiffer.Services;

public class ArgumentHandler : IArgumentHandler
{

    private readonly string[] _args;
    private readonly IApplicationLifecycle _appLifecycle;
    
    public ArgumentHandler(string[] args, IApplicationLifecycle appLifecycle)
    {
        _args = args;
        _appLifecycle = appLifecycle;
    }

    public void ValidateNumberOfArgs()
    {
        if (_args.Length != 5)
            _appLifecycle.EndApplication("Invalid number of arguments.");
    }
    
    public bool ValidShift()
    {
        return _args[2] == "--shift" && int.TryParse(_args[3], out var value);
    }
    
    public int GetShift()
    {
        if (ValidShift())
            return int.Parse(_args[3]);
        _appLifecycle.EndApplication("Shift argument is not an integer.");
        return 0;
    }

    private bool ValidText()
    {
        return _args[0] == "--text" && File.Exists(_args[1]);
    }
    
    public string GetText()
    {
        if (ValidText())
            return File.ReadAllText(_args[1]);
        _appLifecycle.EndApplication("File not found.");
        return null!;
    }
    
    public bool ValidMethod()
    {
        return _args[4] == "--encrypt" || _args[4] == "--decrypt";
    }
    
    public string GetMethod()
    {
        if (ValidMethod())
            return _args[4];
        _appLifecycle.EndApplication("Invalid cipher method.");
        return null!;
    }
}