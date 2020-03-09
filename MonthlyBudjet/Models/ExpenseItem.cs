using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyBudjet.Models
{
    public class ExpenseItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Amout { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string IconImageResourceId { get; set; }
    }
}
