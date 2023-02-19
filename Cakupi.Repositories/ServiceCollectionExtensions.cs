using ClickHouse.Client.ADO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Minio;

namespace Cakupi.Repositories;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection) {
        serviceCollection.AddSingleton(provider => {
            var options = provider.GetRequiredService<IOptions<ClickHouseOptions>>().Value;

            return new ClickHouseConnection(options.Dsn ?? throw new InvalidOperationException("ClickHouseOptions.Dsn in required"));
        });

        serviceCollection.AddSingleton(provider => {
            var options = provider.GetRequiredService<IOptions<MinioOptions>>().Value;

            return new MinioClient()
                   .WithEndpoint(options.Url ?? throw new InvalidOperationException("MinioOptions.Url is required"))
                   .WithCredentials(
                       options.AccessId ?? throw new InvalidOperationException("MinioOptions.AccessId is required"),
                       options.SecretKey ?? throw new InvalidOperationException("MinioOptions.SecretKey is required"))
                   .WithSSL(options.Secure)
                   .WithRegion(options.Region);
        });

        return serviceCollection;
    }
}
