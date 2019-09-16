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
	public partial class prestamos : ContentPage
	{
		public prestamos ()
		{
			InitializeComponent ();
            inicializar();
		}

        private void inicializar()
        {
            agregarprestamobtn.Clicked += Agregarprestamobtn_Clicked;
        }

        private void Agregarprestamobtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new agregarprestamo());
        }
    }
}