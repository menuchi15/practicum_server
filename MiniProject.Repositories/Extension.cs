using Microsoft.Extensions.DependencyInjection;
using MiniProject.Repositories.Interfaces;
using MiniProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Repositories
{
    public static class Extension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IUserDetailsRepository, UserDetailsRepository>();
            return service;
        }
    }
}
