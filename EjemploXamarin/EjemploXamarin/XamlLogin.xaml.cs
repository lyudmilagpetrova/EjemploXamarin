using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;

namespace EjemploXamarin
{
    public partial class XamlLogin : ContentPage
    {
        public XamlLogin()
        {
            InitializeComponent();
        }
        public void OnClick1(object sender, EventArgs e)
        {
            DisplayAlert("Boom", "Boom", "Ok");
        }
    }
}
