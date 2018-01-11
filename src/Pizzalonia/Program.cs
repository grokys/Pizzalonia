using System;
using Avalonia;
using Pizzalonia.ViewModels;
using Pizzalonia.Views;

namespace Pizzalonia
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                //.LogToDebug()
                .Start<MainWindow>(() => new MainWindowViewModel());
        }
    }
}
