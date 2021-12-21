using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using ClassLibraryApp; 

namespace SampleConsoleAppWithClassLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var host = CreateDefaultBuilder().Build();

            //// Invoke Worker
            //using IServiceScope serviceScope = host.Services.CreateScope();
            //IServiceProvider provider = serviceScope.ServiceProvider;
            //var workerInstance = provider.GetRequiredService<Worker>();
            //workerInstance.DoWork();

            //host.Run();
            ClassLibraryApp.Class1 x = new Class1();
            var s = x.CanAccess();

        }

        static IHostBuilder CreateDefaultBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(app =>
                {
                    app.AddJsonFile("appsettings.json");
                })
                .ConfigureServices(services =>
                {
                    services.AddSingleton<Worker>();
                });
        }
    }
}
