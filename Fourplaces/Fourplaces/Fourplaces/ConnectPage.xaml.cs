using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TD.Api.Dtos;


namespace Fourplaces
{
    public partial class ConnectPage : ContentPage
    {

        public ConnectPage()
        {
            InitializeComponent();
        }
        private async void OnConnectClicked(object sender, EventArgs e)
        {
            var login = log.Text;
            var password = passwd.Text;
            ApiService serv = new ApiService();
            var body = new LoginRequest();
            body.Email =login;
            body.Password =password;
            var uri = ApiService.API_LOG;
            var resp = await serv.Execute(HttpMethod.Post, uri, body);

            if (resp.IsSuccessStatusCode)
            {
                var res = await serv.ReadFromResponse<LoginResult>(resp);
                var param = new Dictionary<string, object>();
                param.Add("result", res);
                await Navigation.PushAsync(new MenuPage(param));
            }
            else
            {
                result.Text = "Try again";
            }

        }
    }
}
