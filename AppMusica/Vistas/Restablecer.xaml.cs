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
    public partial class Restablecer : ContentPage
    {
        public Restablecer()
        {
            InitializeComponent();
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnreset_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exitoso());

        }

        private void btninicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicioSesion());
        }
    }
}