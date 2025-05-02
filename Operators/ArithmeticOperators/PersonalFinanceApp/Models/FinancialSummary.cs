using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.ArithmeticOperators.PersonalFinanceApp.Models
{
    public class FinancialSummary
    {
        public decimal NetIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal TotalCapital { get; set; }
        public decimal RemaingBalance { get; set; }
    

    public FinancialSummary() { }

        public FinancialSummary(decimal netIncome, decimal totalExpenses, decimal deductionAmount, decimal totalCapital,decimal remaingBalance)
        {
            NetIncome = netIncome;
            TotalExpenses = totalExpenses;
            DeductionAmount = deductionAmount;
            TotalCapital = totalCapital;
            RemaingBalance = remaingBalance;
        }
    }
}
