using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TD.Api.Dtos;
using System.Net.Http;
using Common.Api.Dtos;

namespace Fourplaces
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage(Dictionary<string, object> param)
        {
            InitializeComponent();  
        }

        private async void OnPlacesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage());
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

    }
}
