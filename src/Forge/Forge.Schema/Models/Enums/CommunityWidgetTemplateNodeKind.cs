namespace Forge.Schema.Models.Enums;

/// <summary>
///  Primitive node kinds allowed inside of community widget templates
/// </summary>
public enum CommunityWidgetTemplateNodeKind
{
    Unknown = -1,
    Stack,
    Grid,
    Boarder,
    Label,
    Text,
    Gauge,
    CircularGauge,
    HUD,
    Separator,
    Community
}