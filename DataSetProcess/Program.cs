using Microsoft.Extensions.Configuration;

namespace DataSetProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultado = true;
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            Settings settings = config.GetRequiredSection("Settings").Get<Settings>();

            FileProcess procesarFichero= new FileProcess();
            procesarFichero.Destino = settings.FicheroDestino;
            Log saveLog = new Log();
            saveLog.InitLog();
            foreach(var ficheroOrigen in settings.FicherosOrigen)
            {
                resultado= procesarFichero.Process(ficheroOrigen);
                if (resultado) {
                    saveLog.WriteLog(ficheroOrigen + " - ok !!!");
                } else
                {
                    saveLog.WriteLog(ficheroOrigen + " - KO");
                }
            }
                        
        }
    }
}