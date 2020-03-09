using MonthlyBudjet.Models;
using MonthlyBudjet.Services;
using MonthlyBudjet.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonthlyBudjet.ViewModels
{
    public class MonthlyExpensesMainPageViewModel : INotifyPropertyChanged
    {
        public MonthlyExpensesMainPageViewModel()
        {
            DisplayStartContentLayout = true;
            DisplayMainContentLayout = false;

            var service = new ExpenseItemsServices();
            Expenses = service.GetExpenseItems();
        }
        public string MonthlyTarget { set; get; }
        public bool DisplayStartContentLayout { set; get; }
        public bool DisplayMainContentLayout { set; get; }



        public ObservableCollection<ExpenseItem> Expenses { set; get; }

        public ICommand AddExpenseCommand
        {
            get {
                return new Command(async () => {
                    //await App.Current.MainPage.DisplayAlert("Greeting Page", "Hi..!", "Ok");
                    await PopupNavigation.Instance.PushAsync(new AddExpensePopupPage());
                });
            }
        }

        public ICommand SaveTargetCommand
        {
            get
            {
                return new Command(async () => {
                    if (string.IsNullOrEmpty(MonthlyTarget) == false)
                    {
                        await App.Current.MainPage.DisplayAlert("Monthly Goal", "Your Target Saved Successfully!", "Ok");
                        DisplayStartContentLayout = false;
                        DisplayMainContentLayout = true;
                        OnPropertyChanged("DisplayStartContentLayout");
                        OnPropertyChanged("DisplayMainContentLayout");
                        OnPropertyChanged("MonthlyTarget");
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Monthly Goal", "You have to set your monthly goal!", "Ok");
                    }
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
