using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploXamarin.Vistas
{
    public class Login : ContentPage
    {
        public Login()
        {
            var labelname = new Label
            {
                Text = "Username"
            };
            var inputname = new Entry
            {
                Placeholder = "Username"
            };
            var labelpass = new Label
            {
                Text = "Password"
            };
            var inputpass = new Entry
            {
                Placeholder = "Password",
                

            };
            var button = new Button
            {
                ClassId = "Button",
                Text = "Login"
            };
            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { labelname, inputname, labelpass, inputpass, button }
            };

        }
    }
}
