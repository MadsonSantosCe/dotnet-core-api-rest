using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using rest_api.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildeWebHost(args);

            using (var scope = host.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<AppDbContext>())
            {
                context.Database.EnsureCreated();
            }

            host.Run();
        }        

        public static IWebHost BuildeWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
}
