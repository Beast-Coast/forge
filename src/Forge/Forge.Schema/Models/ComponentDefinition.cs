namespace Forge.Schema.Models;

public sealed record ComponentDefinition(
    string Id,
    string Name,
    string Description,
    double DefaultWidth,
    double DefaultHeight,
    IReadOnlyList<WidgetPlacement> WidgetPlacements);