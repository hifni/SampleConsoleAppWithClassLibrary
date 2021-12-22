using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ClassLibraryApp
{
    public class Class1
    {
        private IConfiguration _configuration;

        public Class1()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            this._configuration = builder.Build();
        }
        public string spitOut()
        {
            var value1 = Environment.GetEnvironmentVariable("APPSETTING_Org").ToString();
            var value2 = _configuration["AppSettings:Org"];
            return $"From Environment: {value1} From JSON File: {value2}"; 
        }
    }

    public class Class2 : ConfigManager
    {
        public Class2():base()
        {
           
        }

        public string spitOut()
        {
            var value1 = Environment.GetEnvironmentVariable("APPSETTING_Org").ToString();
            var value2 = GetConfigurationSection("AppSettings:Org").Value;
            return $"From Environment: {value1} From JSON File: {value2}";
        }
    }
}
