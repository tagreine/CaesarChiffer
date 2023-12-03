using System.Text;

namespace CaesarChiffer.Services;

public static class CaesarCipher
{
    public static void GenerateText(string text, int shift, string method, StringBuilder processedText, string alphabet)
    {
        foreach (var letter in text)
        {
            // continue to next line if next line character
            if (letter == '\n')
            {
                processedText.Append('\n');
                continue;
            }
            
            // create a mutable character
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
                processedText.Append(alphabet[idx] == 'æ' ? ' ' : alphabet[idx]);
            }
            else
                processedText.Append(alphabet[idx]);
        }
        
        Console.WriteLine($"encrypted text : {processedText}");
    }
}