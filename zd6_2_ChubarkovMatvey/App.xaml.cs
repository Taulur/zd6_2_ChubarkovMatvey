using System;
using System.Security.Cryptography.X509Certificates;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_2_ChubarkovMatvey
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            string username = "";
            MainPage = new NavigationPage(new MainPage(username));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
