using System;

public interface IWidget : ICloneable
{
    void SetConfiguration(string configuration);
    void Display();
}