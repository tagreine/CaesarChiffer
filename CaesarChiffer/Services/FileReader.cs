using CaesarChiffer.Interfaces;

namespace CaesarChiffer.Services;

public static class FileReader
{
    public static string ReadText(string filename, ILogInfo log)
    {
        var text = File.Exists(filename) ? File.ReadAllText(filename) : string.Empty;
        if (string.IsNullOrEmpty(text))
            log.Log("File does not exist");
        return text;
    }
}