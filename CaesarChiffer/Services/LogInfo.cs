using CaesarChiffer.Interfaces;

namespace CaesarChiffer.Services;

public class LogInfo : ILogInfo
{
    
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}