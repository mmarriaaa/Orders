using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using OrdersService;
using OrdersService.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var builderConfiguration = builder.Configuration;

services.Configure<Configuration>(builder.Configuration);
services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(builderConfiguration.GetConnectionString("OrderServiceDatabase")));
services.AddLocalization(options => options.ResourcesPath = "Resources");

var app = builder.Build();

var appConfiguration = app.Configuration.Get<Configuration>();
var cultureName = appConfiguration.Culture;
var supportedCultures = appConfiguration.SupportedCultures.ToList();

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(cultureName),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});

app.UseMiddleware<ExceptionHandler>();

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