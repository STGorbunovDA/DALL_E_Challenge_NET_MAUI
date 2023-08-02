using DALL_E_Challenge_NET_MAUI.Views;

namespace DALL_E_Challenge_NET_MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashboardView();
        }
    }
}