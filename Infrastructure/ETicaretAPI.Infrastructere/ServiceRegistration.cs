using ETicaretAPI.Application.Services;
using ETicaretAPI.Infrastructere.Services;
using Microsoft.Extensions.DependencyInjection;


namespace ETicaretAPI.Infrastructere
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
        }
    }
}
