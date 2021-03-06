using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp
{
    public interface IConfigurationManager
    {
        IConfigurationSection GetConfigurationSection(string Key);
    }
}
