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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            registrobtn.Clicked += registrobtn_Clicked;
        }

        private async void registrobtn_Clicked(object sender, EventArgs e)
        {
            //aqui se toman los datos del registro, tengo que llevar al formulario iniciosesion.xaml.cs estas dos variables
            //Application.Current.Properties["correo"] y Application.Current.Properties["contraseña"]
            //pero no se si si almacenan los registros, y aunque lo hicieran este metodo no me parece el correcto para guardar
            //los datos y no se como guardarlos de otra forma
            String nombre = entrynombre.Text;
            String correo = entrycorreo.Text;
            String telefono = entrytelefono.Text;
            String contraseña = entrycontraseña.Text;

            Application.Current.Properties["nombre"] = nombre;
            Application.Current.Properties["correo"] = correo;
            Application.Current.Properties["telefono"] = telefono;
            Application.Current.Properties["contraseña"] = contraseña;
            await Application.Current.SavePropertiesAsync();
            if ((nombre == entrynombre.Text) && (contraseña == entrycontraseña.Text))
            {
#pragma warning disable CS4014 // Ya que no se esperaba esta llamada, la ejecución del método actual continúa antes de que se complete la llamada
                Navigation.PushAsync(new iniciosesion());
#pragma warning restore CS4014 // Ya que no se esperaba esta llamada, la ejecución del método actual continúa antes de que se complete la llamada
            }

        }
    }
}