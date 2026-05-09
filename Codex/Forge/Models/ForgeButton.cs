namespace Forge.Models;

public class ForgeButton : IForgeButton
{
    public string Content { get; set; }
    public string BackgroundColor { get; set; }
    public double? Width { get; set; }
    public double? Height { get; set; }
}