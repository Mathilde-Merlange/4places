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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            AfficherLieux();
        }

        private async void AfficherLieux()
        {
            ApiService serv = new ApiService();
            var resp = await serv.Execute(HttpMethod.Get, ApiService.API_PLACE);

            if (resp.IsSuccessStatusCode)
            {
                var result = await serv.ReadFromResponse<Response<List<PlaceItemSummary>>>(resp);
                var places = result.Data;
                foreach (var x in places)
                {
                    Label titre = new Label { Text = x.Title };
                    //Image img = new Image { Source = "" };
                    Label desc =  new Label { Text = x.Description };
                    BoxView bx = new BoxView { HeightRequest = 2.0};
                    new Button { Text = x.Title };
                    st.Children.Add(titre);
                    //st.Children.Add(img);
                    st.Children.Add(desc);
                    st.Children.Add(bx);
                    Content = st;
                }
            }
        }
    }
}
