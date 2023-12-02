using CaesarChiffer.Interfaces;

namespace CaesarChiffer.Services;

public class ArgumentValidator
{

    private readonly string[] _args;
    private readonly ILogInfo _log;

    public ArgumentValidator(string[] args, ILogInfo log)
    {
        _args = args;
        _log = log;
    }
    private bool NumberOfArgs()
    {
        if (_args.Length == 5)
            return true;
        _log.Log("Incorrect number of arguments");
        return false;
    }

    private bool IsParseable()
    {
        if (int.TryParse(_args[3], out var value))
            return true;
        
        _log.Log("Incorrect argument type for --shift");
        return false;
    }

    public bool Validate()
    {
        return IsParseable() && NumberOfArgs();
    }
    
}