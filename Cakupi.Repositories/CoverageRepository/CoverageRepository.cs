using Cakupi.RepositoryInterfaces;
using ClickHouse.Client.ADO;

namespace Cakupi.Repositories.CoverageRepository;

public class CoverageRepository : ICoverageRepository {
    private readonly ClickHouseConnection _clickHouseConnection;

    public CoverageRepository(ClickHouseConnection clickHouseConnection) {
        _clickHouseConnection = clickHouseConnection;
    }
}
