using System;

namespace CSharpPractices
{
    public static class Desbordamiento
    {
        // Método para demostrar el comportamiento con 'checked'
        public static void DemostracionChecked()
        {
            try
            {
                checked
                {
                    int maxInt = int.MaxValue; // numero maximo entero
                    int overflow = maxInt + 1; // Esto lanzará una OverflowException
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Desbordamiento capturado en bloque checked: " + ex.Message);
            }
        }

        // Método para demostrar el comportamiento con 'unchecked'
        public static void DemostracionUnchecked()
        {
            unchecked
            {
                int maxInt = int.MaxValue;
                int overflow = maxInt + 1; // No lanza OverflowException, resultado incorrecto
                Console.WriteLine("Resultado en bloque unchecked (desbordamiento ignorado): " + overflow);
            }
        }
    }
}