using System.Text;
using CaesarChiffer.Interfaces;
using CaesarChiffer.Services;


// TODO rename project and solution to Caesar or something else, Chiffer is the Norwegian word for it
namespace CaesarChiffer;

internal static class Program
{
    private static void Main(string[] args)
    {
        // TODO add a --help console argument to show how to use the application
        // TODO move all object instantiations, i.e., new Object, into a Factory method
        IApplicationLifecycle appLifecycle = new ApplicationLifecycle();
        IArgumentHandler argumentHandler = new ArgumentHandler(args, appLifecycle);
        argumentHandler.ValidateNumberOfArgs();
        
        var encryptedText = new StringBuilder();
        var processedText = CaesarCipher.GenerateText(argumentHandler.GetText(), argumentHandler.GetShift(), argumentHandler.GetMethod(), encryptedText, Alphabet.GetAlphabet());
        Console.WriteLine($"encrypted text : {processedText}");
    }
}
