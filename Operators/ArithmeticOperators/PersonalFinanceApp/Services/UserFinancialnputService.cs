using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators.ArithmeticOperators.PersonalFinanceApp.Models;

namespace Operators.ArithmeticOperators.PersonalFinanceApp.Services
{

    public class ServiceInput
    {

        public UserFinancialProfile GetUserFinancialData()
        {
            Console.WriteLine("¿Cual es tu nombre?");
            string name = Console.ReadLine();
            decimal monthlyIncome = AskForDecimal ("¿Cual es su ingreso mensual?");
            decimal monthlyExpenses = AskForDecimal ("¿Cual es su gasto mensual?");
            decimal monthlyPurshase = AskForDecimal ("¿Cuales son sus compras mensuales, indique numero?");
            decimal currentSavings = AskForDecimal ("¿Cuanto tienes ahorrado actualmente?");
            decimal deductionPercentage = AskForDecimal("¿Cual es el porcentaje del ingreso que le descuentan del trabajo?");

            return new UserFinancialProfile
            {
                Name = name,
                MonthlyIncome = monthlyIncome,
                MonthlyExpenses = monthlyExpenses,
                MonthlyPurchase = monthlyPurshase,
                CurrentSaving = currentSavings,
                DeductionPercentage = deductionPercentage,
            };  

        }
        private decimal AskForDecimal(string message)
        {
            decimal value;
            Console.WriteLine($"{message}");
            while (!decimal.TryParse(Console.ReadLine(), out value) || value < 0)
            {
                Console.WriteLine("Por favor ingrese un numero valido");
            }
            return value;
        }
    }
}
