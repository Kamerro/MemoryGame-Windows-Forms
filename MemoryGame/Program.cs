using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using MemoryGame.Generators;
using MemoryGame.Services;

namespace MemoryGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<MemoGame>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<ICardGenerator, CardGenerator>();
                    services.AddTransient<ICleanerService, CleanerService>();
                    services.AddTransient<IGameInitializer, GameInitializer>();
                    services.AddTransient<IImageClickEventHandler, ImageClickEventHandler>();
                    services.AddTransient<IMemoryGameService, MemoryGameService>();
                    services.AddTransient<ITickService, TickService>();
                    services.AddTransient<IMemoryGameService, MemoryGameService>();
                    services.AddTransient<MemoGame>();
                    services.AddTransient<IImageService, ImageService>();
                });
        }
    }
}
