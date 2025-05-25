using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;

namespace Ordering;

public static class OrderingModule
{
    public static IServiceCollection AddOrderingModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        // TODO: Add your services to the container here
        // services
        //     .AddApplicationServices()
        //     .AddInfrastructureServices(configuration)
        //     .AddApiServices(configuration)

        return services;
    }

        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
    {
        //TODO: Configure the Http request pipeline.
        //app
        //    .UseApplicationServices()
        //    .UseInfrastructureServices()
        //    .UseApiServices();
        return app;
    }
    }