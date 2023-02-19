namespace Cakupi.ServiceInterfaces;

public interface ICoverageReporter {
    Task Report(string repository, string commitHash, string commitBranch, IList<FileStream> files);
}
