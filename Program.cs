using System;

namespace Serilog.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Console()
               .WriteTo.File("logs\\logs.txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();

            Log.Information("Bem Vindo, Serilog !");

            int a = 10, b = 0;
            try
            {
                Log.Debug("Dividindo {A} por {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Alguma coisa deu errado...");
            }

            Log.CloseAndFlush();
            Console.ReadKey();
        }
    }
}
