using Microsoft.Extensions.Configuration;
using System;
using System.IO;

public static class ConfigHelper
{
    public static string GetConnectionString(string name)
    {
        var basePath = AppContext.BaseDirectory;
        var configFile = Path.Combine(basePath, "appsettings.json");

        if (!File.Exists(configFile))
        {
            throw new FileNotFoundException(
                "Configuration file 'appsettings.json' was not found. Verify it exists and is copied to the output directory.",
                configFile);
        }

        var config = new ConfigurationBuilder()
            .SetBasePath(basePath) // Más confiable que Directory.GetCurrentDirectory()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var connectionString = config.GetConnectionString(name);

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException(
                $"Connection string '{name}' was not found. Verify that 'appsettings.json' contains this entry.");
        }

        return connectionString;
    }
}

