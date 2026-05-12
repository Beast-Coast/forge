namespace Forge.Schema.Models;
/// <summary>
/// Metadata for a template
/// </summary>
/// <param name="Id"></param>
/// <param name="Name"></param>
/// <param name="Version"></param>
/// <param name="Author"></param>
/// <param name="Description"></param>
public sealed record TemplateMetadata(
    string Id,
    string Name,
    string Version,
    string Author,
    string? Description = null);