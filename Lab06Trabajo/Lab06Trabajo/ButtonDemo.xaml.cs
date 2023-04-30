﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06Trabajo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ButtonDemo : ContentPage
	{
		public ButtonDemo ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}