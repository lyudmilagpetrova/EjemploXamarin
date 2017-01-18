using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using
using EjemploXamarin.Vistas;
using Xamarin.Forms;

namespace EjemploXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamlLogin();
        }

        protected override void OnStart()
        {
            //loading...esto es porque esta aberiguando quen eres y mostrarte lo visto ya
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
           //falta de conexion y se duerme como si fuera en segundo plano
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            //lo vuelve a abrir despues de haber encontrado conexion
            // Handle when your app resumes
        }
    }
}
