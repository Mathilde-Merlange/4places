using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fourplaces
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSubscribeClicked(object sender, EventArgs e)
        {
            var mail = email.Text;
            var nom = lastname.Text;
            var prenom = firstname.Text;
            var passwd = password.Text;


        }
        private async void OnConnectClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectPage());
        }

    }
}
