namespace AS.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class loginViewModel : BaseViewModel
    {

        #region Attributes
        private string Email;
        private string Password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string email
        {
            get { return this.Email; }
            set { SetValue(ref this.Email, value); }
        }

        public string password
        {
            get { return this.Password; }
            set { SetValue(ref this.Password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion

        #region Constructors
        public loginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;

            this.email = "admin@admin.com";
            this.password = "admin";
        }
        #endregion

        #region Comands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes ingresar un correo electronico",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes ingresar una contraseña",
                    "Aceptar");
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;


            if (this.email != "admin@admin.com" || this.password != "admin")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "email y contraseña incorrectos",
                    "Aceptar");
                this.password = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            this.email = string.Empty;
            this.password = string.Empty;

            MainViewModel.GetInstance().AS = new HomepageViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new Homepage());
        }
        #endregion


    }
}
