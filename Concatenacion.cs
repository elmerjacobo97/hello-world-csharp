namespace CSharpPractices
{
  public static class Concatenacion
  {
    // Método para practicar la concatenación básica
    public static void ConcatenacionBasica()
    {
      string parte1 = "Hola, ";
      string parte2 = "mundo!";
      string resultado = parte1 + parte2;

      Console.WriteLine(resultado);
    }

    // Método para practicar la concatenación con el operador $
    public static void ConcatenacionConInterpolacion()
    {
      string nombre = "Elmer";
      int edad = 30;
      string resultado = $"Mi nombre es {nombre} y tengo {edad} años.";

      Console.WriteLine(resultado);
    }

    // Método para practicar la concatenación con StringBuilder
    public static void ConcatenacionConStringBuilder()
    {
      var stringBuilder = new System.Text.StringBuilder();
      stringBuilder.Append("Este es ");
      stringBuilder.Append("un ejemplo ");
      stringBuilder.Append("de StringBuilder.");

      string resultado = stringBuilder.ToString();
      Console.WriteLine(resultado);
    }
  }
}
