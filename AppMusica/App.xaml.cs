﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppMusica.Vistas;

namespace AppMusica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage(new Inicio());
        

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
