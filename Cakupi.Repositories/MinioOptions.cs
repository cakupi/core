namespace Cakupi.Repositories;

public class MinioOptions {
    public string Url { get; set; } = "localhost:9000";
    public bool Secure { get; set; } = false;
    public string? AccessId { get; set; }
    public string? SecretKey { get; set; }
    public string? Region { get; set; }
}
