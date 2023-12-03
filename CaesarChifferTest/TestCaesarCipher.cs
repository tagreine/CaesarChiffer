using System.Text;

namespace CaesarChifferTest;

public class TestCaesarCipher
{
    // TODO add more unit tests to ensure more stable code
    [Fact]
    public void EncryptDecryptEquals()
    {
        const string inputText = "abcde";
        const string targetText = "bcdef";
        
        var encrypted = CaesarCipher.GenerateText(inputText, 1,  "--encrypt", new StringBuilder(), Alphabet.GetAlphabet());
        var decrypted = CaesarCipher.GenerateText(encrypted, 1, "--decrypt", new StringBuilder(), Alphabet.GetAlphabet());
        
        Assert.Equal(targetText, encrypted);
        Assert.Equal(inputText, decrypted);
    }
}
