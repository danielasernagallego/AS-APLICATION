﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class balance : ContentPage
	{
		public balance ()
		{
			InitializeComponent ();

            inicializar();
		}

        private void inicializar()
        {
            
        }
    }
}