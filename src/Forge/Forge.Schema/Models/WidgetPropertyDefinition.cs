namespace Forge.Schema.Models;

using Enums;
/// <summary>
/// Declares a configurable property exposed by a community widget.  Template nodes can bind these properties using values like {player.name}.
/// </summary>
public sealed record WidgetPropertyDefinition(
    string Name,
    TemplateValueKind Kind,
    TemplateValue Value);