namespace Cakupi.Repositories;

public class ClickHouseOptions {
    public string Dsn { get; set; } = "Host=clickhouse;Port=8123;Username=default;password=;Database=default";
}
