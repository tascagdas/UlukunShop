using Microsoft.Extensions.Configuration;

namespace UlukunShopAPI.Persistence;

static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            //connection stringi appsettings icinden alabilmek icin 2 eklenti yuklendi. burada hangi json dosyasina gidecegini gosteriyoruz.
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/UlukunShopAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");
            
            return configurationManager.GetConnectionString("PostgreSQL");
        }
    }
}