namespace Forge.Schema.Models;

/// <summary>
/// A grid coordinated for placing containers
/// </summary>
/// <param name="Row"></param>
/// <param name="Column"></param>
/// <param name="RowSpan"></param>
/// <param name="ColumnSpan"></param>
public sealed record GridPosition(int Row, int Column, int RowSpan = 1, int ColumnSpan = 1);