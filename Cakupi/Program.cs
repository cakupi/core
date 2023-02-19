using Cakupi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
       .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
       .AddKeyPerFile("/run/secrets", optional: true, reloadOnChange: true)
       .AddEnvironmentVariables("ASPNETCORE_");

// Acquire repository configurations
builder.Services.Configure<ClickHouseOptions>(builder.Configuration.GetSection("ClickHouseOptions"));
builder.Services.Configure<MinioOptions>(builder.Configuration.GetSection("MinioOptions"));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
