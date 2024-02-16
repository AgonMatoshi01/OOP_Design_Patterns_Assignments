using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Website : IComponent
{
    private readonly List<IComponent> _components = new List<IComponent>();

    public void AddComponent(IComponent component)
    {
        _components.Add(component);
    }

    public void RemoveComponent(IComponent component)
    {
        _components.Remove(component);
    }

    public void Display()
    {
        foreach (var component in _components)
        {
            component.Display();
        }
    }
}