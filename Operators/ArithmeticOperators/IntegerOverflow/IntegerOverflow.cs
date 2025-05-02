using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.ArithmeticOperators.IntegerOverflow
{
    public class IntegerOverflow
    {
        public static void Run()
        {
            int maxValue = int.MaxValue;
            Console.WriteLine("📌 Valor máximo que puede almacenar un 'int': " + maxValue); // 2147483647

            // Ejemplo de desbordamiento no controlado
            int overflowedValue = maxValue + 1;
            Console.WriteLine($"Resultado de maxValue + 1 (sin checked): {overflowedValue}"); //  -2147483648 El valor se reincia y da un numero negativo

            // Ejemplo de desbordamiento controlado con 'checked'
    
            try
            {
                int safeValue = checked(maxValue + 1); //Usamos checked para controlar el desbordamiento
                Console.WriteLine($"Resultado controlado: {safeValue}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("❌¡Error detectado! Se ha producido un desbordamiento controlado.");
                Console.WriteLine("Mensaje de la excepción: " + ex.Message); // Arithmetic operation resulted in an overflow.
            }
        }
    }
}
