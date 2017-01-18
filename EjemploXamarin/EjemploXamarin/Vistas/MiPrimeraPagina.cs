using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add using
using Xamarin.Forms;

namespace EjemploXamarin.Vistas
{
    //te creas tu carpeta Vistas y a su nivel esta clese
    //hariamos la clase publica y herederia de ContenPage
    public class MiPrimeraPagina : ContentPage
    {
        //nos creamos el constructor
        public MiPrimeraPagina()
        {
            var label = new Label
            {
                Text = "Mira que etiquetaza"
            };

            var input = new Entry
            {
                Placeholder = "Esto es una caja para escribir"
            };
            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                //tiene dos hijos
                Children = { label, input }
            };
        }
    }
}
