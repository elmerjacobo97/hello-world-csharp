namespace CSharpPractices
{
  public static class Metodos
  {
    // Método simple sin retorno y sin parámetros
    public static void MetodoSimple()
    {
      Console.WriteLine("Ejecutando MetodoSimple()");
    }

    // Método que toma parámetros y devuelve un valor
    public static int Sumar(int numero1, int numero2)
    {
      return numero1 + numero2;
    }

    // Método con parámetros opcionales
    public static string Saludar(string nombre, string saludo = "Hola")
    {
      return $"{saludo}, {nombre}!";
    }

    // Sobrecarga de métodos
    public static double Sumar(double numero1, double numero2)
    {
      return numero1 + numero2;
    }
  }
}
