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
	public partial class iniciosesion : ContentPage
	{
		public iniciosesion ()
		{
			InitializeComponent ();
            inicializar();
        }

        private void inicializar()
        {
            iniciocuentabtn.Clicked += Iniciocuentabtn_Clicked;
        }

        private void Iniciocuentabtn_Clicked(object sender, EventArgs e)
        {   
        }
    }
}