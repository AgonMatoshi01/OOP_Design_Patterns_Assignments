using System;

public class TextWidget : IWidget
{
    private string _configuration;

    public void SetConfiguration(string configuration)
    {
        _configuration = configuration;
    }

    public void Display()
    {
        Console.WriteLine($"Text Widget: {_configuration}");
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
