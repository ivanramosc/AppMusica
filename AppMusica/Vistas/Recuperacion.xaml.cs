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
    public partial class Recuperacion : ContentPage
    {
        public Recuperacion()
        {
            InitializeComponent();
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btninicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicioSesion());

        }

        private void btnenviar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Verificacion());
        }
    }
}