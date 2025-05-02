using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators.ArithmeticOperators.PersonalFinanceApp.Services;
using Operators.ArithmeticOperators.PersonalFinanceApp.Models;

namespace Operators.ArithmeticOperators.PersonalFinanceApp
{
    public static class FinanceApp
    {
        public static void Run()
        {
            Console.Clear();
         
            var reportService = new FinancialReportService();
            var inputService = new ServiceInput();
            var calculateFinance = new FianancialCalculate();

            var profile = inputService.GetUserFinancialData();
            var calculate = calculateFinance.CalculateFinancialSummary(profile);

            reportService.ShowReport(calculate);

            
        }
    }
}
