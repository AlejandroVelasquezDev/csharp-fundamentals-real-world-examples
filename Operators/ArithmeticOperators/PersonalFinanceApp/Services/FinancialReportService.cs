using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators.ArithmeticOperators.PersonalFinanceApp.Models;

namespace Operators.ArithmeticOperators.PersonalFinanceApp.Services
{
    public class FinancialReportService
    {

        public void ShowReport (FinancialSummary userReport)
        {
            Console.WriteLine($"El ingreso neto del usuario es: {userReport.NetIncome}");
            Console.WriteLine($"Los gatos totales son: {userReport.TotalExpenses}");
            Console.WriteLine($"La cantidad total deducida es: {userReport.DeductionAmount}");
            Console.WriteLine($"El saldo restante es: {userReport.RemaingBalance}");
            Console.WriteLine($"El total de capital es: {userReport.TotalCapital}");
        }
    }
}
