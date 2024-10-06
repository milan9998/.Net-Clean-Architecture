using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoDB.Entities;

namespace USP.Infrastructure;

public static class DependencyInjection
{
    public static  IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {
        var conn = configuration.GetSection("MongoDbConfiguration");
        Task.Run(async () =>
        {
            await DB.InitAsync(conn.GetSection("DbName").Value!,
                MongoClientSettings.FromConnectionString(conn.GetSection("DbString").Value));
        }).GetAwaiter().GetResult();

        

        return services;
    }
}























