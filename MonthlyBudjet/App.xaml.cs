using MonthlyBudjet.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonthlyBudjet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new MonthlyExpensesMainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
