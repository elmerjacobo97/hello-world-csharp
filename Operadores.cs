namespace CSharpPractices
{
  public static class Operadores
  {
    // Método para practicar operadores aritméticos
    public static void PracticaOperadoresAritmeticos()
    {
      int a = 10;
      int b = 3;

      Console.WriteLine($"Suma: {a + b}");
      Console.WriteLine($"Resta: {a - b}");
      Console.WriteLine($"Multiplicación: {a * b}");
      Console.WriteLine($"División: {a / b}");
      Console.WriteLine($"Módulo: {a % b}");
    }

    // Método para practicar operadores de asignación
    public static void PracticaOperadoresAsignacion()
    {
      int c = 10;
      c += 5; // equivalente a c = c + 5
      Console.WriteLine($"c += 5: {c}");

      c -= 3; // equivalente a c = c - 3
      Console.WriteLine($"c -= 3: {c}");
    }

    // Método para practicar operadores de comparación
    public static void PracticaOperadoresComparacion()
    {
      int a = 10;
      int b = 20;

      Console.WriteLine($"a == b: {a == b}"); // Igualdad
      Console.WriteLine($"a != b: {a != b}"); // Desigualdad
      Console.WriteLine($"a < b: {a < b}");  // Menor que
      Console.WriteLine($"a > b: {a > b}");  // Mayor que
      Console.WriteLine($"a <= 10: {a <= 10}"); // Menor o igual que
      Console.WriteLine($"b >= 20: {b >= 20}"); // Mayor o igual que
    }

    // Método para practicar operadores lógicos
    public static void PracticaOperadoresLogicos()
    {
      bool x = true;
      bool y = false;

      Console.WriteLine($"x && y: {x && y}"); // Y lógico
      Console.WriteLine($"x || y: {x || y}"); // O lógico
      Console.WriteLine($"!x: {!x}"); // NOT lógico
    }

  }
}
