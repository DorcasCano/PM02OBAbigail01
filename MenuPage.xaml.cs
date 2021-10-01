using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02OperBasica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void btnapp1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }

        private async void btnapp2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.BindingPage());
        }
    }
}