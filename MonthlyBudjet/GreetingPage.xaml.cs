using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonthlyBudjet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetingPage : ContentPage
    {
        public GreetingPage()
        {
            InitializeComponent();

            //sliderVlaueLabel.Text = string.Format("Value is {0:F2}", slider.Value);
            slider.Value = 0.5;

            //.. Dealing With Device Differences => use Device class //
        }

        private void Handle_ClickMeBtn(object sender, EventArgs e)
        {
            DisplayAlert("Greeting Page", "Hi..!", "Ok");
        }
    }
}