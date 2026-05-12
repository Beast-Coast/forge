namespace Forge.Schema.Models;
/// <summary>
/// Allows you to convert a template to a different UI format
/// </summary>
/// <typeparam name="T"></typeparam>

public interface ITemplateVisitor<out T>
{
    T Visit(LayoutTemplate template);
}