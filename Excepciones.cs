using System;

namespace CSharpPractices
{
    public static class Excepciones
    {
        // Siempre las excepciones de manera especifica(DivideByZeroException, IndexOutOfRangeException,
        // NullReferenceException, FormatException, etc) van primero, despues la generica que es Exception
        // Método para practicar el manejo de excepciones con un bloque try-catch
        public static void CapturaExcepcionDividePorCero()
        {
            try
            {
                int divisor = 0;
                int resultado = 10 / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Capturada una excepción DivideByZeroException: " + ex.Message);
            }
        }

        // Método para practicar el manejo de múltiples excepciones
        public static void CapturaMultiplesExcepciones()
        {
            try
            {
                var array = new int[] { 1, 2, 3 };
                Console.WriteLine(array[5]); // Esto generará una excepción
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Índice fuera de los límites del array: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Capturada una excepción genérica: " + ex.Message);
            }
        }

        // Método para practicar el manejo de FormatException
        public static void CapturaFormatException()
        {
            try
            {
                Console.WriteLine("Introduce un número:");
                string entrada = Console.ReadLine();
                int numero = int.Parse(entrada); // Esto puede lanzar FormatException
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Formato incorrecto: " + ex.Message);
            }
        }

        // Método para practicar el manejo de NullReferenceException
        public static void CapturaNullReferenceException()
        {
            try
            {
                string texto = null;
                int longitud = texto.Length; // Esto puede lanzar NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Referencia a objeto no establecida: " + ex.Message);
            }
        }

        // Método para practicar el manejo de excepciones no específicas - catch-all
        public static void CapturaExcepcionGenerica()
        {
            try
            {
                // Código que puede lanzar diferentes tipos de excepciones
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción capturada: " + ex.Message);
            }
        }
        
        // Método para practicar el uso de finally en el manejo de excepciones
        public static void UsoDeFinally()
        {
            try
            {
                // Intenta abrir un archivo o alguna otra operación
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido una excepción: " + ex.Message);
            }
            finally
            {
                // Este bloque siempre se ejecutará, con excepción o sin ella
                Console.WriteLine("Este es el bloque finally, que siempre se ejecuta.");
            }
            
            // Otro ejemplo de uso de finally, pero con lectura de archivos
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0; // Inicializa contador
                string ruta = @"/Users/elmer/Desktop/Test/test.txt";

                archivo = new System.IO.StreamReader(ruta);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido un error: {ex.Message}");
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }

                Console.WriteLine("La conexión se ha cerrado.");
                
            }
        }
        
        // Método para practicar la captura de excepciones con filtro
        public static void CapturaExcepcionConFiltro()
        {
            try
            {
                // Supongamos que este código puede lanzar varias excepciones
                int resultado = int.Parse("NoEsUnNumero"); // Esto lanzará FormatException
            }
            catch (FormatException ex) when (ex.Message.Contains("NoEsUnNumero")) // ex.GetType() == typeof(FormatException)
            {
                Console.WriteLine("Excepción FormatException específica capturada: " + ex.Message);
            }
            catch (FormatException ex)
            {   
                // Captura cualquier otra FormatException
                Console.WriteLine("Excepción FormatException genérica capturada: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro tipo de excepción
                Console.WriteLine("Excepción genérica capturada: " + ex.Message);
            }
        }
        
        // Método para practicar el uso de 'throw' para lanzar una excepción
        public static void LanzarExcepcionConThrow()
        {
            try
            {
                Console.WriteLine("Introduce un número mayor que 0:");
                string entrada = Console.ReadLine();
                int numero = int.Parse(entrada);

                if (numero <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(numero), "El número debe ser mayor que 0.");
                }

                Console.WriteLine("El número ingresado es válido.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Formato incorrecto: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Argumento fuera de rango: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción capturada: " + ex.Message);
            }
        }
    }
}