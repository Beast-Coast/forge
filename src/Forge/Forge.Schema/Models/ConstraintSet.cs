namespace Forge.Schema.Models;
/// <summary>
/// Input constraints for <see cref="Forge.Schema.Models.Enums.WidgetType"/> such as numeric ranges, text lenght, regex, or dropdown options.
/// </summary>
/// <param name="Min"></param>
/// <param name="Max"></param>
/// <param name="MaxLenght"></param>
/// <param name="Regex"></param>
/// <param name="Options"></param>
public sealed record ConstraintSet(
    double? Min = null,
    double? Max = null,
    int? MaxLenght = null,
    string? Regex = null,
    IReadOnlyList<string>? Options = null);