using System.Text;

namespace CaesarChiffer.Services;

public static class CaesarCipher
{
    public static string GenerateText(string text, int shift, string method, StringBuilder processedText, string alphabet)
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
            // TODO remove hardcoded character 'æ' in the alphabet. Maybe change to something more general than 'æ', to include other languages
            // TODO add alphabet with upper with conditions
            var character = letter;
            if (method == "--encrypt" && letter == ' ')
                character = 'æ';
            
            var index = alphabet.IndexOf(character);
            
            // generate indexes of the Caesar Cipher shifted letters
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

        return processedText.ToString();
    }
}