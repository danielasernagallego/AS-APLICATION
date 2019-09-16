using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            inicializar();
        }

        private void inicializar()
        {
            iniciosesionbtn.Clicked += iniciosesionbtn_Clicked;
            registrarsebtn.Clicked += Registrarsebtn_Clicked;
        }

        private void Registrarsebtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        private void iniciosesionbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new iniciosesion());
        }
    }
}
