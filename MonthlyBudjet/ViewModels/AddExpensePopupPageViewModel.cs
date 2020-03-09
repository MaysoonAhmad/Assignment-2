using MonthlyBudjet.Models;
using MonthlyBudjet.Services;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonthlyBudjet.ViewModels
{
    public class AddExpensePopupPageViewModel
    {
        public string ExpenseAmount { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseCategory { get; set; }

        public List<string> CategoriesList {
            get {
                return new List<string>() {
                    "Fitness",
                    "Shopping",
                    "Home",
                    "Car",
                    "Utilities",
                    "entertainment"
                };
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                return new Command(async () => {
                    
                    await PopupNavigation.Instance.PopAsync(true);
                });
            }
        }

        public ICommand SaveExpenseCommand
        {
            get
            {
                return new Command(async () => {

                    var service = new ExpenseItemsServices();
                    service.AddExpenseItem(new ExpenseItem() {
                        Amout = Convert.ToDouble(ExpenseAmount),
                        Name = ExpenseName,
                        IconImageResourceId = string.Format("{0}.jpg", ExpenseCategory.ToLower()),
                        Id = Guid.NewGuid().ToString(),
                        DateTimeStamp = DateTime.Now
                    });

                    await PopupNavigation.Instance.PopAsync(true);
                });
            }
        }

    }
}
