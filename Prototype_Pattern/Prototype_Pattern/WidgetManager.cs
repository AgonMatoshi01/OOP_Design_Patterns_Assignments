using System;
using System.Collections.Generic;

public class WidgetManager
{
    private readonly Dictionary<string, IWidget> _widgets = new Dictionary<string, IWidget>();

    public void AddWidget(string key, IWidget widget)
    {
        _widgets[key] = widget;
    }

    public IWidget GetWidget(string key)
    {
        return (IWidget)_widgets[key].Clone();
    }
}
