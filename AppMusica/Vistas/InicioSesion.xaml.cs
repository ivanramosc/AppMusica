using AppMusica.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMusica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioSesion : ContentPage
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private async void btnvolver_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btnrecuperar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recuperacion());


        }
    }
}