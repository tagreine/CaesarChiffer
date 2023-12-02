using System.Text;
using CaesarChiffer.Services;

namespace CaesarChiffer;

internal static class Program
{
    private static void Main(string[] args)
    {
        var log = new LogInfo();
        var argumentValidator = new ArgumentValidator(args, log);
        
        if (!argumentValidator.Validate())
            return;
        
        var text = FileReader.ReadText(args[1], log);
        if (string.IsNullOrEmpty(text))
            return;
        
        var shiftNum = int.Parse(args[3]);
        var method = args[4];
        var encryptedText = new StringBuilder();
        CaesarCipher.GenerateText(text, shiftNum, method, encryptedText, Alphabet.GetAlphabet());
    }
}

