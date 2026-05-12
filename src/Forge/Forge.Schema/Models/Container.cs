namespace Forge.Schema.Models;
using Enums;

/// <summary>
/// A regin that owns widget placements and participates in teh top level layout.
/// Sandbox containers support free-form widget placement; other types can be interpreted by designer/rendering layers
/// </summary>
public record Container(
    string Id,
    string Label,
    GridPosition GridPosition,
    int Columns,
    int Rows,
    double Width,
    double Height,
    IReadOnlyList<WidgetPlacement> WidgetPlacements,
    ContainerStyle? Style = null,
    ContainerType? Type = ContainerType.Sandbox);