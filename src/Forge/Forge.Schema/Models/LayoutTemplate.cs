namespace Forge.Schema.Models;
/// <summary>
/// The root document imported/exported.
/// It contains canvas metadata, containers, resuable components, and optional embedded community widgets.
/// </summary>
public record LayoutTemplate(
    TemplateMetadata templateMetadata,
    CanvasSize CanvasSize,
    IReadOnlyList<Container> Containers,
    IReadOnlyList<ComponentDefinition> ComponentDefinitions,
    IReadOnlyList<CommunityWidgetDefinition>? CommunityWidgets = null);