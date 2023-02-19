namespace Cakupi.Primitives;

public sealed record CoverageFile {
    public required string FileName { get; init; }
    public required string FilePath { get; init; }
    public required ulong TotalStatements { get; init; }
    public required ulong TotalStatementsCovered { get; init; }
    public required float PercentageCovered { get; init; }
    public required IList<CoverageLine> CoverageLines { get; init; }
};
