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
	public partial class deudas : ContentPage
	{
		public deudas ()
		{
			InitializeComponent ();
            inicializar();
		}

        private void inicializar()
        {
            agregardeudabtn.Clicked += Agregardeudabtn_Clicked;
        }

        private void Agregardeudabtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new agregardeuda());
        }
    }
}