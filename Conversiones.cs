namespace CSharpPractices
{
  public static class Conversiones
  {
    // Método para practicar la conversión de enteros a decimales
    public static void EnteroADecimal()
    {
      int entero = 10;
      decimal decimalConvertido = entero;
      Console.WriteLine($"Entero: {entero}, Decimal convertido: {decimalConvertido}");
    }

    // Método para practicar la conversión de decimales a enteros
    public static void DecimalAEntero()
    {
      decimal decimalNumero = 10.5m;
      int enteroConvertido = (int)decimalNumero;
      Console.WriteLine($"Decimal: {decimalNumero}, Entero convertido: {enteroConvertido}");
    }

    // Método para practicar otras conversiones, como float a double, etc.
    public static void OtrasConversiones()
    {
      float floatNumero = 10.5f;
      double doubleConvertido = floatNumero;
      Console.WriteLine($"Float: {floatNumero}, Double convertido: {doubleConvertido}");

      // Agrega aquí más ejemplos de conversiones
    }
  }
}
