using AD.Api.Domains;
using AD.Api.Ldap.Converters.Json;
using AD.Api.Middleware;
using AD.Api.Services;
using AD.Api.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json");

static IEnumerable<SearchDomain> GetSearchDomains(IEnumerable<IConfigurationSection> sections)
{
    foreach (IConfigurationSection section in sections)
    {
        SearchDomain dom = section.Get<SearchDomain>();
        dom.FQDN = section.Key;
        yield return dom;
    }
}

// Add services to the container.

IConfigurationSection section = builder.Configuration.GetSection("Domains");
builder.Services.AddSingleton(new SearchDomains(GetSearchDomains(section.GetChildren())));
SearchDefaults defaults = builder.Configuration.GetSection("Settings").GetSection("SearchDefaults").Get<SearchDefaults>();
builder.Services.AddSingleton(defaults);
builder.Services.AddSingleton<IUserSettings>(x => x.GetRequiredService<SearchDefaults>().User);
builder.Services.AddSingleton<IComputerSettings>(x => x.GetRequiredService<SearchDefaults>().Computer);
builder.Services.AddSingleton<IGenericSettings>(x => x.GetRequiredService<SearchDefaults>().Generic);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.Converters.Add(new FilterConverter());
    options.SerializerSettings.Converters.Add(new PathValueJsonConverter());
    options.SerializerSettings.Converters.Add(new StringEnumConverter());

    options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
    options.SerializerSettings.Formatting = Formatting.Indented;
    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    options.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IConnectionService, ConnectionService>();
builder.Services.AddSingleton<ISerializationService, SerializationService>();

var app = builder.Build();

app.Services.GetService<IOptions<MvcNewtonsoftJsonOptions>>();

app.UseExceptionHandler(new ExceptionHandlerOptions
{
    ExceptionHandler = new ErrorHandlingMiddleware().Invoke
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
