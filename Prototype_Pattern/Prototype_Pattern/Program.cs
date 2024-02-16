using System;

class Program
{
    static void Main()
    {
        var widgetManager = new WidgetManager();

        var textWidgetPrototype = new TextWidget();
        textWidgetPrototype.SetConfiguration("Test text widget");
        widgetManager.AddWidget("TextWidget", textWidgetPrototype);

        var chartWidgetPrototype = new ChartWidget();
        chartWidgetPrototype.SetConfiguration("Test char widget");
        widgetManager.AddWidget("ChartWidget", chartWidgetPrototype);

        // Clone and display widgets
        var clonedTextWidget = (IWidget)widgetManager.GetWidget("TextWidget");
        clonedTextWidget.Display();

        var clonedChartWidget = (IWidget)widgetManager.GetWidget("ChartWidget");
        clonedChartWidget.Display();
    }
}
