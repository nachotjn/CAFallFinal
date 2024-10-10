using global::CAFallAPI;
using global::Microsoft.EntityFrameworkCore;
using global::Microsoft.AspNetCore.Builder;
using global::Microsoft.Extensions.Configuration;
using global::Microsoft.Extensions.DependencyInjection;

var builder = global::Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

global::Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext<global::CAFallAPI.AppDbContext>(options =>
    options.UseNpgsql(global::Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString("DefaultConnection")));

global::Microsoft.Extensions.DependencyInjection.MvcServiceCollectionExtensions.AddControllers();

var app = builder.Build();

global::Microsoft.AspNetCore.Builder.HttpsPolicyBuilderExtensions.UseHttpsRedirection();
global::Microsoft.AspNetCore.Builder.AuthorizationAppBuilderExtensions.UseAuthorization();
global::Microsoft.AspNetCore.Builder.ControllerEndpointRouteBuilderExtensions.MapControllers();

app.Run();