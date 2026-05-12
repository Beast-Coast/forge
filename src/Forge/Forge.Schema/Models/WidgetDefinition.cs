namespace Forge.Schema.Models;

/// <summary>
/// Describes a widget independent of its position.
/// </summary>
/// <param name="Id"></param>
/// <param name="Label"></param>
/// <param name="Type"></param>
/// <param name="DefaultValue"></param>
/// <param name="Constraints"></param>
/// <param name="Properties"></param>
public sealed record WidgetDefinition(
    String Id,
    string Label,
    Enums.WidgetType Type,
    TemplateValue? DefaultValue = null,
    ConstraintSet? Constraints = null,
    IReadOnlyDictionary<string, TemplateValue>? Properties = null);