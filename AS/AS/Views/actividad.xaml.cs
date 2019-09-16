using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class actividad : ContentPage
	{
		public actividad ()
		{
			InitializeComponent ();
            inicializar();
        }

        private void inicializar()
        {
            prestamosbtn.Clicked += Prestamosbtn_Clicked;
            deudasbtn.Clicked += Deudasbtn_Clicked;
        }

        private void Prestamosbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new prestamos());
        }

        private void Deudasbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new deudas());
        }

    }
}