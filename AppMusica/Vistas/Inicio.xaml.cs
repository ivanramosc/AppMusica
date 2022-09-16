using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMusica.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void btniniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InicioSesion());
        }

        private void btnregistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrarse());
        }

        private void btninvitado_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPrincipal());
        }
    }
}