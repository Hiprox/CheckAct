using System;
using System.IO;
using System.Threading.Tasks;
using Application.Infrastructure.Persistence.Migrations;
using CheckAct.Application.Utility;
using CheckAct.Infrastructure;
using LinqToDB;
using LinqToDB.Data;
using Microsoft.Extensions.Logging;
using Serilog;

namespace CheckAct.Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try
            {
                var root = Directory.GetCurrentDirectory();
                var dotenv = Path.Combine(root, ".env");
                DotEnv.Load(dotenv);

                DIContainer.Migrator.EnsureDbExists(DIContainer.Config.SqlConnectionString, typeof(CreateDocumentsTable).Assembly);

                CheckActContext.SetOptions(new DataOptions()
                    .UsePostgreSQL(DIContainer.Config.SqlConnectionString));

                DataConnection.TurnTraceSwitchOn();
                DataConnection.WriteTraceLine = (s1, s2, _) => Log.Information("{0} {1}", s1, s2);
                ApplicationConfiguration.Initialize();
                System.Windows.Forms.Application.Run(new CheckAct());
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Unhandled exception");
            }
            finally
            {
                await Log.CloseAndFlushAsync();
            }
        }
    }
}