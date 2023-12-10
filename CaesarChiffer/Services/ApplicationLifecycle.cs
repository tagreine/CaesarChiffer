using CaesarChiffer.Interfaces;

namespace CaesarChiffer.Services;

public class ApplicationLifecycle : IApplicationLifecycle
{
    
    public void EndApplication(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Press Enter to exit application");
        Console.ReadLine();
        Environment.Exit(0);
    }
}