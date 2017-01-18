using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploXamarin.Vistas
{
    public class Login: ContentPage
    {
        public Login()
        {
            var labelname = new Label
            {
                Text = "Username",
                //con esto conseguimos coger los tamaños de las pantallas y 
                //que el label se vea igual en todos los dispositivos 
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Italic,
                TextColor = Color.Gray
            };
            var labelNameBorde = new Frame
            {
                OutlineColor = Color.Red,
                Content = labelname
            };
            var inputname = new Entry
            {
                Placeholder = "Username"
            };
            var labelpass = new Label
            {
                Text = "Password"
            };
            var labelPassBorde = new Frame
            {
                OutlineColor = Color.Red,
                Content = labelpass
            };
            var inputpass = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };
            var button = new Button
            {
                ClassId = "Button",
                Text = "Login"
            };
            button.Clicked += (sender, args) =>
            {
                DisplayAlert("Boom", "Boom", "Exploto");
            };
            var image = new Image
            {
                Aspect = Aspect.AspectFit
            };
            image.Source = "http://blogs.heraldo.es/ciencia/files/2009/09/protonotaria.jpg";
            //image.Source = ImageSource.FromFile("cosmos.jpg");
            var cajaBordeInput = new Frame
            {
                //content puede tener solo un hijo, por eso creamos StackLayout
                //que te permite tener mas hijos
                Content = new StackLayout
                {
                    Children = { inputname, inputpass, }
                }
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Padding = 30,
                Spacing = 10,
                Children = { image, labelNameBorde, labelPassBorde, cajaBordeInput, button }
            };
        }
    }
}
