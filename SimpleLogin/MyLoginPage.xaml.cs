using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SimpleLogin
{
    public partial class MyLoginPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(username.Text=="admin" && password.Text=="12345")
            {
                DisplayAlert("success!","correct credentials","ok");
            }
            else{
                DisplayAlert("Failure","wrong credentials","Try Again");
            }
        }

        public MyLoginPage()
        {
            InitializeComponent();
        }
    }
}
