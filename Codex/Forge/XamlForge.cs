using System.IO;
using Avalonia.Markup.Xaml;
using Portable.Xaml;

namespace Forge;

public static class XamlForge
{
    // Direction 1: Object Tree -> XAML String
    public static string SerializeToXaml(object uiModel)
    {
        return XamlServices.Save(uiModel);
    }

    // Direction 2: XAML String -> Live Avalonia Control
    public static T LoadFromXaml<T>(string xaml) where T : class
    {
        // Avalonia requires the base namespaces to be present
        // You might need a helper to wrap the xaml in a root Avalonia tag if it's missing
        return (T)AvaloniaRuntimeXamlLoader.Load(xaml);
    }
}