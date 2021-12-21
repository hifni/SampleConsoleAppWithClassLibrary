using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp
{
    public class ConfigurationManager: IConfigurationManager
    { 
        private readonly IConfiguration _configuration;
        public ConfigurationManager(IConfiguration configuration)
        {
            //this._configuration = configuration;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            this._configuration = builder.Build();
        }

        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }

    }
}
