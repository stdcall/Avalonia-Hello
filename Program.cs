using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using MyApp.ViewModels;
using MyApp.Views;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MainWindowViewModel();
            BuildAvaloniaApp().Start<MainWindow>(() => context);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
