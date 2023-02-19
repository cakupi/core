namespace Cakupi.Primitives;

public sealed record CoverageLine {
    public required ulong LineNumber { get; init; }
    public required ulong HitsCount { get; init; }
    public required bool FullyCovered { get; init; } = false;
    public required LineType LineType { get; init; } = LineType.Unspecified;
};
