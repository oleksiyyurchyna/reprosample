using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ReproSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var firebase = DependencyService.Get<IFirebaseAuthenticator>();

            await firebase.TestSingInAndVerification("test@test.com", "123456");
        }
    }
}
