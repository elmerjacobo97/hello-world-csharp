namespace CSharpPractices
{
    public static class Bucles
    {
        // Método para practicar el bucle for
        public static void PracticaFor()
        {
            Console.WriteLine("Contando del 1 al 10 con bucle for:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Método para practicar el bucle while - mientras
        public static void PracticaWhile()
        {
            int contador = 1;
            Console.WriteLine("Contando del 1 al 10 con bucle while:");
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

        // Método para practicar el bucle do-while - has mientras - ejecuta el bucle al menos una vez
        public static void PracticaDoWhile()
        {
            int contador = 1;
            Console.WriteLine("Contando del 1 al 10 con bucle do-while:");
            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador <= 10);
        }

        // Ejemplo de un bucle for que recorre una colección
        public static void RecorrerColeccion()
        {
            string[] frutas = { "manzana", "banana", "cereza" };
            Console.WriteLine("Lista de frutas:");
            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i]);
            }
        }

        // Ejemplo de un bucle while para una condición no determinada por conteo
        public static void EsperarUsuario()
        {
            Console.WriteLine("Presiona 's' para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.S)
            {
                Console.WriteLine("No presionaste 's'. Intenta de nuevo.");
            }
            Console.WriteLine("Continuando con la ejecución del programa.");
        }
    }
}