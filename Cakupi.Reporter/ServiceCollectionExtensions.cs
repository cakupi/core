using Microsoft.Extensions.DependencyInjection;

namespace Cakupi.Reporter;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddReporterClient(this IServiceCollection serviceCollection) {
        serviceCollection.AddSingleton<ReporterClient>();
        return serviceCollection;
    }
}
