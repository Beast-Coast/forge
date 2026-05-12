namespace Forge.Schema.Models;
/// <summary>
/// Widget inside a container with free form coordinates refrened by <see cref="Forge.Schema.Models.WidghetDefinition.ComponentId"/>
/// </summary>
public sealed record WidgetPlacement(
    string Id,
    double X,
    double Y,
    double Width,
    double Height,
    int ZIndex,
    WidgetDefinition WidgetDefinition);