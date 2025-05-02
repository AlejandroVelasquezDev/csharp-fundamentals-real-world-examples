using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.ArithmeticOperators.PersonalFinanceApp.Models
{
    public class UserFinancialProfile
    {

        public string Name { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal MonthlyExpenses { get; set; }

        public decimal MonthlyPurchase { get; set; }
        public decimal CurrentSaving { get; set; }

        public decimal DeductionPercentage { get; set; }

        public UserFinancialProfile() { }   
        public UserFinancialProfile(string name, decimal monthlyIncome, decimal monthlyExpenses, decimal monthlyPurchase, decimal currentSaving, decimal deductionPercentage)
        {
            Name = name;
            MonthlyIncome = monthlyIncome;
            MonthlyExpenses = monthlyExpenses;
            MonthlyPurchase = monthlyPurchase;
            CurrentSaving = currentSaving;
            DeductionPercentage = deductionPercentage;
        }
    }
}
