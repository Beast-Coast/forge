namespace Forge.Schema.Models;
using Enums;

/// <summary>
/// A typed literal value used for weiget defaults, constraints, and community widget proeprty values.
/// Only these values are allowed in imported data.
/// </summary>
public sealed record TemplateValue(
    TemplateValueKind TemplateValueKind,
    string? StringValue = null,
    double? NumberValue = null,
    bool? BooleanValue = null,
    DateTimeOffset? DateTimeOffsetValue = null)
{
    public static TemplateValue Empty { get; } = new(TemplateValueKind.Empty);
    public static TemplateValue Text(string value) => new TemplateValue(TemplateValueKind.Text, StringValue: value);
    public static TemplateValue Number(double value) => new TemplateValue(TemplateValueKind.Number, NumberValue: value);
    public static TemplateValue Boolean(bool value) => new TemplateValue(TemplateValueKind.Boolean, BooleanValue: value);

    public static TemplateValue DateTimeOffset(DateTimeOffset value) =>
        new TemplateValue(TemplateValueKind.DateTimeOffset, DateTimeOffsetValue: value);
}
