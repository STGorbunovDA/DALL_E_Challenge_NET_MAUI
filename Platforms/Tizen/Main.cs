using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace DALL_E_Challenge_NET_MAUI
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}