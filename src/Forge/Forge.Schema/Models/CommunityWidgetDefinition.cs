namespace Forge.Schema.Models;
using Enums;
/// <summary>
/// Defines one importable community widget node from guarded template nodes and typed properties.
/// These are registerd by ID and can then be placed on the UI as <see cref="Forge.Schema.Models.Enums.WidgetType.Community"/> widgets
/// </summary>
public sealed record CommunityWidgetDefinition(
    TemplateMetadata templateMetadata,
    double DefaultWidth,
    double DefaultHeight,
    IReadOnlyList<WidgetPropertyDefinition> Properties,
    CommunityWidgetTemplateNode TemplateNode);
