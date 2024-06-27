using Application.Repositories;
using Infrastructure.Contexts;
using Infrastructure.Repostiories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfraStructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddTransient<IRepo, GameRepo>()
                .AddDbContext<ApplicationDbContext>(Options => Options
                    .UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
