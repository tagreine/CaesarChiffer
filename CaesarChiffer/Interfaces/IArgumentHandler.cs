namespace CaesarChiffer.Interfaces;

public interface IArgumentHandler
{
    public bool ValidShift();
    public bool ValidMethod();
    public void ValidateNumberOfArgs();
    public int GetShift();
    public string GetMethod();
    public string GetText();
}