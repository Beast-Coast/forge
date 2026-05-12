namespace Forge.Schema.Models;

/// <summary>
/// Visual style for a Container.  These values are data only and interpreted by renderers
/// </summary>
/// <param name="Border"></param>
/// <param name="Background"></param>
public sealed record ContainerStyle(bool Border = false, string? Background = null);