namespace Forge.Schema.Models.Validations;
/// <summary>
/// A validation report
/// </summary>
public sealed record ValidationError(string Code, string Message, string? Path = null);