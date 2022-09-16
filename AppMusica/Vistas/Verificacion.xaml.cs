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
    public partial class Verificacion : ContentPage
    {
        public Verificacion()
        {
            InitializeComponent();
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnenviar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Restablecer());

        }

        private void btninicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicioSesion());

        }
    }
}