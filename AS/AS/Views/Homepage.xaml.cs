using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms.Xaml;

namespace AS
{

    using Xamarin.Forms;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Homepage : ContentPage
	{
		public Homepage ()
		{
			InitializeComponent ();

            inicializar();
        }

        private void inicializar()
        {
            actividadbtn.Clicked += Actividadbtn_Clicked;
            balancebtn.Clicked += Balancebtn_Clicked;
            historialbtn.Clicked += Historialbtn_Clicked;
        }

        private void Historialbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new historial());
        }

        private void Balancebtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new balance());
        }

        private void Actividadbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new actividad());
        }
    }
}