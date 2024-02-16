using System;

public class ChartWidget : IWidget
{
    private string _configuration;

    public void SetConfiguration(string configuration)
    {
        _configuration = configuration;
    }

    public void Display()
    {
        Console.WriteLine($"Chart Widget: {_configuration}");
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
