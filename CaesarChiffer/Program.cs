using System.Text;
using CaesarChiffer.Services;

namespace CaesarChiffer;

internal static class Program
{
    private static void Main(string[] args)
    {
        // TODO move all object instantiations, i.e., new Object, into a Factory method
        var log = new LogInfo();
        // TODO create interface for ArgumentValidator
        var argumentValidator = new ArgumentValidator(args, log);
        
        if (!argumentValidator.Validate())
            return;
        
        var text = FileReader.ReadText(args[1], log);
        if (string.IsNullOrEmpty(text))
            return;
        
        // TODO move rest of arguments into the ArgumentValidator class to validate (maybe rename class to ArgumentProcessor)
        var shiftNum = int.Parse(args[3]);
        var method = args[4];
        var encryptedText = new StringBuilder();
        var processedText = CaesarCipher.GenerateText(text, shiftNum, method, encryptedText, Alphabet.GetAlphabet());
        Console.WriteLine($"encrypted text : {processedText}");
    }
}
