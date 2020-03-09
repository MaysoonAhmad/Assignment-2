using MonthlyBudjet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MonthlyBudjet.Services
{
    public class ExpenseItemsServices
    {
        private static ObservableCollection<ExpenseItem> _expenses;

        public ExpenseItemsServices()
        {
            if(_expenses == null)
            {
                _expenses = new ObservableCollection<ExpenseItem>();
            }
        }

        public ObservableCollection<ExpenseItem> GetExpenseItems()
        {
            return _expenses;
        }

        public void AddExpenseItem(ExpenseItem item)
        {
            _expenses.Add(item);
        }
    }
}