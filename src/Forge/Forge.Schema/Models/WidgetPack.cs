namespace Forge.Schema.Models;
/// <summary>
/// A sharable collection of widget definitions.
/// </summary>
public sealed record WidgetPack(
    TemplateMetadata templateMetadata,
    IReadOnlyList<CommunityWidgetDefinition> Widgets);