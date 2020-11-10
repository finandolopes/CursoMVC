using System.Collections;

namespace WebApp
{
    class Settings
    {
        private Hashtable configs;

        public Settings()
        {
            configs = new Hashtable();
            configs.Add("ConnectionString", "Host=localhost;Port=5432;Pooling=true;Database=WebApp;User Id=postgres;Password=12345");
            configs.Add("DefaultSchema", "CursoMVC");
        }

        public string Get(string setting) =>
            (string) configs[setting];
    }
}