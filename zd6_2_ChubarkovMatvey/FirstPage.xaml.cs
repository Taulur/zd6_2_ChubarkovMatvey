using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace zd6_2_ChubarkovMatvey
{
    public partial class MainPage : ContentPage
    {

        public string username;
        public MainPage(string usernameFrom)
        {
            InitializeComponent();
            username = usernameFrom;
            loginButton.IsEnabled = false;
        }

      

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (usernameEntry.Text != null && passwordEntry.Text != null)
            {
                await Navigation.PushAsync(new Page3(username));
                username = usernameEntry.Text;
            }
        }

        private void rememberMeCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            loginButton.IsEnabled = e.Value;
        }
    }
}
