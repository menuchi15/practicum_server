using Microsoft.Extensions.DependencyInjection;
using MiniProject.DataContext;
using MiniProject.Repositories;
using MiniProject.Repositories.Interfaces;
using MiniProject.Repositories.Repositories;
using MiniProject.Services.Interfaces;
using MiniProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Services
{
    public static class Extension
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddDbContext<IContext, MyDataContext>();
            service.AddRepositories();
            service.AddAutoMapper(typeof(Mapping));
            service.AddScoped<IUserDetailsService,UserDetailsService>();
            return service;
        }
    }
}
