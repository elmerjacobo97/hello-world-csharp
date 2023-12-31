namespace CSharpPractices
{
    public static class Operadores
    {
        // Método para practicar operadores aritméticos con ejemplos
        public static void PracticaOperadoresAritmeticos()
        {
            int a = 10;
            int b = 3;

            // Ejemplos de operaciones aritméticas
            Console.WriteLine($"Suma: {a + b}");            // Resultado esperado: 13
            Console.WriteLine($"Resta: {a - b}");           // Resultado esperado: 7
            Console.WriteLine($"Multiplicación: {a * b}");  // Resultado esperado: 30
            Console.WriteLine($"División: {a / b}");        // Resultado esperado: 3 (división entera)
            Console.WriteLine($"Módulo: {a % b}");          // Resultado esperado: 1 (resto de la división)
        }

        // Método para practicar operadores de asignación con ejemplos
        public static void PracticaOperadoresAsignacion()
        {
            int c = 10;
            
            // Ejemplos de operaciones de asignación
            c += 5; // Suma 5 a c
            Console.WriteLine($"c += 5: {c}"); // Resultado esperado: 15

            c -= 3; // Resta 3 a c
            Console.WriteLine($"c -= 3: {c}"); // Resultado esperado: 12
        }

        // Método para practicar operadores de comparación con ejemplos
        public static void PracticaOperadoresComparacion()
        {
            int a = 10;
            int b = 20;

            // Ejemplos de operaciones de comparación
            Console.WriteLine($"a == b: {a == b}"); // Resultado esperado: False
            Console.WriteLine($"a != b: {a != b}"); // Resultado esperado: True
            Console.WriteLine($"a < b: {a < b}");   // Resultado esperado: True
            Console.WriteLine($"a > b: {a > b}");   // Resultado esperado: False
            Console.WriteLine($"a <= 10: {a <= 10}"); // Resultado esperado: True
            Console.WriteLine($"b >= 20: {b >= 20}"); // Resultado esperado: True
        }

        // Método para practicar operadores lógicos con ejemplos
        public static void PracticaOperadoresLogicos()
        {
            bool x = true;
            bool y = false;

            // Ejemplos de operaciones lógicas
            Console.WriteLine($"x && y: {x && y}"); // Resultado esperado: False (True Y False)
            Console.WriteLine($"x || y: {x || y}"); // Resultado esperado: True (True O False)
            Console.WriteLine($"!x: {!x}");         // Resultado esperado: False (NO True)
        }
        
        // Método para practicar operadores lógicos.
        public static void PracticaOperadoresLogicosReales()
        {
            // Ejemplo con operador AND (&&)
            bool licenciaValida = true;
            bool mayorDeEdad = true;
            
            // Si la licencia es válida y es mayor de edad, puede conducir
            if (licenciaValida && mayorDeEdad)
            {
                Console.WriteLine("Puede conducir legalmente.");
            }
            else
            {
                Console.WriteLine("No cumple con los requisitos para conducir.");
            }

            // Ejemplo con operador OR (||)
            bool finDeSemana = false;
            bool diaFestivo = true;
            
            // Si es fin de semana o es un día festivo, no puede asistir
            if (finDeSemana || diaFestivo)
            {
                Console.WriteLine("Puede asistir al evento, ya que es un día libre.");
            }
            else
            {
                Console.WriteLine("No es un día libre, por lo tanto, no puede asistir al evento.");
            }

            // Combinación de operadores AND y OR
            bool tienePasaporte = false;
            bool tieneVisa = true;
            bool necesitaVisa = false;

            if ((tienePasaporte || tieneVisa) && !necesitaVisa)
            {
                Console.WriteLine("Está listo para viajar al extranjero.");
            }
            else
            {
                Console.WriteLine("No está listo para viajar al extranjero.");
            }
        }
    }
}
