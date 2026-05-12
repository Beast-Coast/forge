namespace Forge.Schema.Models;
using Enums;

/// <summary>
/// A data node in the community widget render tree
/// </summary>
public record CommunityWidgetTemplateNode(
    CommunityWidgetTemplateNodeKind Kind,
    string? Label = null,
    string? Text = null,
    string? Current = null,
    string? SecondaryCurrent = null,
    string? SecondaryMaximum = null,
    string? Color = null,
    string? BackgroundColor = null,
    string? OutlineColor = null,
    double? Thickness = null,
    string? ImageSource = null,
    string? ImagePlacement = null,
    string? Orientation = null,
    string? CommunityWidgetId = null,
    IReadOnlyDictionary<string,TemplateValue>? Properties = null,
    IReadOnlyList<CommunityWidgetTemplateNode>? Children = null);