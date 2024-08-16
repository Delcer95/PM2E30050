using Plugin.Maui.Audio;
using PM2E30050.Views;
using PM2E30050.Controllers;
using PM2E30050.Models;

namespace PM2E30050
{
    public partial class App : Application
    {
        public static FirebaseController db = new FirebaseController();
        public static Notas nota;

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new PaginaPrincipal(AudioManager.Current));

        }
    }
}
