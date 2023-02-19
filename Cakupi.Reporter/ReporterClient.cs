using Microsoft.Extensions.Options;

namespace Cakupi.Reporter;

public class ReporterClient {
    private readonly ReporterOptions _reporterOptions;
    public ReporterClient(
        IOptions<ReporterOptions> reporterOptionsAccessor) {
        _reporterOptions = reporterOptionsAccessor.Value;
    }
}
