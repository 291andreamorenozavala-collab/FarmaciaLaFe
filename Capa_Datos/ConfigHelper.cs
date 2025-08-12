using Microsoft.Extensions.Configuration;
using System.IO;

public static class ConfigHelper
{
    public static string GetConnectionString(string name)
    {
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Más confiable que Directory.GetCurrentDirectory()
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var connectionString = config.GetConnectionString(name);

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException($"No se encontró la cadena de conexión con el nombre '{name}'");
            }

            return connectionString;
        }
    }
}
