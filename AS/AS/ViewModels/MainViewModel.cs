using System;
using System.Collections.Generic;
using System.Text;

namespace AS.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public loginViewModel Login
        { 
            get; 
            set; 
        }

        public HomepageViewModel AS
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new loginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }

        #endregion
    }
}
