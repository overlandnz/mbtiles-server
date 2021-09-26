using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace MBTilesServer
{
    public static class ConfigurationManager
    {
        private static readonly IConfigurationRoot RawConfiguration;
        public static string RuntimeEnvironment { get; private set; }

        static ConfigurationManager()
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (String.IsNullOrWhiteSpace(environment) || environment == "Development")
            {
                environment = "dev";
            }

            RuntimeEnvironment = environment;

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.Add(new JsonConfigurationSource {Path = "config.json", Optional = true});
            builder.Add(new JsonConfigurationSource {Path = "appsettings.json", Optional = true});
            builder.Add(new JsonConfigurationSource {Path = string.Format("{0}.config.json", environment), Optional = true});

            if (RuntimeEnvironment.ToLower() != "production")
            {
                builder.Add(new JsonConfigurationSource {Path = "appsettings.Development.json", Optional = true});
            }

            RawConfiguration = builder.Build();
        }

        public static string Read(string key)
        {
            return RawConfiguration[key];
        }

        public static bool IsProduction()
        {
            return RuntimeEnvironment.ToLower() == "production";
        }
    }
}