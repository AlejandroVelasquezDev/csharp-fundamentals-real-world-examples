using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators.ArithmeticOperators.PersonalFinanceApp.Models;

namespace Operators.ArithmeticOperators.PersonalFinanceApp.Services
{
    public class FianancialCalculate
    {
        public FinancialSummary CalculateFinancialSummary(UserFinancialProfile user)
        {
            decimal deductionAmount = user.MonthlyIncome *(user.DeductionPercentage * 100);
            decimal netIncome = user.MonthlyIncome - deductionAmount;
            decimal totalExpenses = user.MonthlyExpenses + user.MonthlyPurchase;
            decimal remaingBalance = netIncome - totalExpenses;
            decimal totalCapital = remaingBalance + user.CurrentSaving;

            return new FinancialSummary
            {
                NetIncome = netIncome,
                TotalExpenses = totalExpenses,
                TotalCapital = totalCapital,
                DeductionAmount = deductionAmount,
                RemaingBalance = remaingBalance,
            };
        }
    }
}
