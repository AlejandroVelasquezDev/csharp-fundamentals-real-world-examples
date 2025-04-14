using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.RelationalOperators
{
    internal class ExampleEducationLoan
    {

        public static void Run()
        {
            /* Ejemplo 1:
            * Simulador de solicitud de crédito educativo.
            * Se validan condiciones como edad, ingresos, estabilidad laboral y nivel de endeudamiento.
            */

            Console.WriteLine("Antes de comenzar ¿cual es su nombre?");
            var name = Console.ReadLine();

            Console.WriteLine($"Bienvenido {name} al simulador de aprobacion de credito bancario");


            Console.WriteLine("Por favor indiquenos la siguiente informacion");
            // Edad
            Console.WriteLine("¿Cual es su edad?");
            int age = int.Parse(Console.ReadLine()); //Guardar edad del usuario (age =) edad)

            //Pregunta ¿Esta actualmente trabajando?
            Console.WriteLine("¿Esta actualmente trabajando? (si/no)");
            string currentlyWork = Console.ReadLine();// Guardar respuesta (currentlyWork = trabaja actualmente)

            //¿Meses de antiguedad en el trabajo?
            Console.WriteLine("¿Hace cuantos meses trabaja en su empleo actual?");
            int monthsInCurrentJob = int.Parse(Console.ReadLine()); // Guardar respuesta  (monthsInCurrentJob = meses en el trabajo actual)

            //¿Cuanto gana?
            Console.WriteLine("Cuanto es su ingreso mensual");
            decimal monthIncome = decimal.Parse(Console.ReadLine()); //Guardar respuesta (monthIncome = ingreso mensual)

            //¿Cuanto gasta mensual?
            Console.WriteLine("Cuantos son sus gastos mensuales");
            decimal currentDebt = decimal.Parse(Console.ReadLine()); //Guardar respuesta (currentDebt = deuda actual)


            //¿De cuanto es el prestamo?
            Console.WriteLine("¿Cual es el valor del prestamo a solicitar?");
            decimal loanAmount= decimal.Parse(Console.ReadLine());// Guardar respuesta (loanAmount = monto del préstamo)

            //Estas son las politicas del banco y evaluan sus datos con los de ellos para la aprobacion .

            decimal minimunSalary = 1623500m; //minimunSalary = salario mínimo requerido
            int loanTerminMonths = 6; // Termino de meses fijos para pagar el prestamo (loanTerminMonth = duracion del prestamo)
            decimal interestRate = 0.012m;// Tase de interes de 1.2% (interestRate = tasa de interes)
            bool isAgeValid = age >= 18; // La edad tiene que ser mayor a 18 años (isAgeValid= es validad la edad)
            bool isCurrentlyEmployed = (currentlyWork == "SI" || currentlyWork == "si" || currentlyWork == "sì");  // El estudiante debera estar trabajando para acceder al prestamo (isCurrentlyEmployed = esta actualmente empleado)
            bool isJobstabilityGood = monthsInCurrentJob >= 6; // Tiene que demostrar que lleva mas de 6 meses en el trabajo isJobStabilityGood = el trabajo es establemente bien)
            bool isIncomeValid = monthIncome > minimunSalary; //El salario debe ser mayor a 1'300.000 (isIcomeValid = es valido el ingreso)
            decimal totalLoanAmount = loanAmount + (loanAmount * interestRate); // (totalLoabAmount = cantidad total del prestamo)
            decimal debRatio = (monthIncome - currentDebt) * 0.35m;//nivel de endeudamiento , se hace la operacion de cuanto debe  dvidido cuanto gana (debRatio = Capacidad de endeudamiento)
            decimal monthlyPayment = totalLoanAmount / loanTerminMonths; // (monthlyPayment = pagos mensuales)
            bool debtRatioAcceptable = monthlyPayment <= debRatio; // (0.4) es 40/100 osea 40% de endeudamiento es riegoso y rechazan el prestamo ( debRatioAcceptable = capacidad de endeudamiento aceptable)
            
            

            Console.WriteLine("Resultados de la evaluacion, Todos nuestros prestamos son a 6 meses cosiderando un semestre academico");

            //Valida que todo sea verdadero si falla en algo no se aprueba el prestamo
            if (isAgeValid && isCurrentlyEmployed && isJobstabilityGood && isIncomeValid && debtRatioAcceptable)
            {
                //Muestra mensaje al cliente
                Console.WriteLine("Felicidades, El banco aprobo su solicitud de prestamo educativo");
                Console.WriteLine($"Nombre cliente: {name}");
                Console.WriteLine($"Valor prestamo solicitado: {loanAmount:C}");
                Console.WriteLine($"Tase de interes: {interestRate*100:F2}%");
                Console.WriteLine($"Valor total prestamo: {totalLoanAmount:C}");
                Console.WriteLine($"Pagos mensuales de: {monthlyPayment:C}");
            }
            //El prestamo no se aprobo y se muestran los detalles de porque
            else
            {
                Console.WriteLine("Lo sentimos pero no cumples con uno o mas requisitos a continuacion los detalles");

                if (!isAgeValid) //pregunta si NO es la edad verdadera 
                    Console.WriteLine("Debes tener almenos 18 años");
                if (!isCurrentlyEmployed) // validad si NO esta actualmente empleado
                    Console.WriteLine("Debes estar trabajando actualmente");
                if (!isJobstabilityGood) // validad si NO es establemente bien en el trabajo
                    Console.WriteLine("Debes de tener al menos 6 meses en el trabajo");
                if (!isIncomeValid) // validad si NO es valido el ingreso
                    Console.WriteLine($"Debes de tener un ingreso minimo de {minimunSalary}");
           
                if (!debtRatioAcceptable)
                
                    Console.WriteLine("La capacidad de endeudamiento no cumple con nuestras politicas");
                
            }

            Console.WriteLine($"Gracias por usar el simulador, Hasta pronto {name}");
        }
    }
}
