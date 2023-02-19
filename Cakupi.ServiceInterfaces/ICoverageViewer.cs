using Cakupi.Primitives;

namespace Cakupi.ServiceInterfaces;

public interface ICoverageViewer {
    Task<CoverageResult> Get(string repository, string? commitHash, string? commitBranch, CancellationToken cancellationToken);
}
