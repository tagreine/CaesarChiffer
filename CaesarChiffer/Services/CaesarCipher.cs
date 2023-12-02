using System.Text;

namespace CaesarChiffer.Services;

public static class CaesarCipher
{
    public static void GenerateText(string text, int shift, string method, StringBuilder encryptedText, string alphabet)
    {
        foreach (var letter in text)
        {
            var character = letter;
            if (method == "--encrypt" && letter == ' ')
                character = 'æ';
            
            var index = alphabet.IndexOf(character);
            
            int idx; 
            if (method == "--encrypt")
                idx = (index + shift) % alphabet.Length;
            else 
                idx = ((index - shift) % alphabet.Length + alphabet.Length) % alphabet.Length;
            
            if (method == "--decrypt")
            {
                encryptedText.Append(alphabet[idx] == 'æ' ? ' ' : alphabet[idx]);
            }
            else
                encryptedText.Append(alphabet[idx]);
        }
        
        Console.WriteLine($"encrypted text : {encryptedText}");
    }
}