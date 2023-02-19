namespace Cakupi.Primitives;

public sealed record CoverageResult {
    public required ulong TotalStatements { get; init; }
    public required ulong TotalStatementsCovered { get; init; }
    public required float PercentageCovered { get; init; }
    public required IList<CoverageFile> CoverageFiles { get; init; }
};
