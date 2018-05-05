using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Sansagol.CyberFox.CyberFoxApi
{
    /// <summary>
    /// Manage of app configuration.
    /// </summary>
    public class ConfigManager : IConfigurationManager
    {
        private IConfiguration BaseConfiguration { get; set; }
        private IConfigurationRoot SecretConfig { get; set; }

        public ConfigManager(IConfiguration baseConfiguration)
        {
            BaseConfiguration = baseConfiguration ?? throw new ArgumentNullException("The configuration was not receive.");

            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<Startup>();
            SecretConfig = builder.Build();
        }

        public string GetConnectionString()
        {
            return SecretConfig.GetConnectionString("MsSqlConnectionString");
        }
    }
}
