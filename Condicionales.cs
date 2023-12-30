namespace CSharpPractices
{
  public static class Condicionales
  {
    // Método para practicar la estructura condicional if
    public static void PracticaIf()
    {
      int numero = 10;

      if (numero > 5)
      {
        Console.WriteLine("El número es mayor que 5.");
      }
      else
      {
        Console.WriteLine("El número es menor o igual a 5.");
      }
    }

    // Método para practicar la estructura condicional switch
    public static void PracticaSwitch()
    {
      int mes = 4;
      string nombreMes;

      switch (mes)
      {
        case 1:
          nombreMes = "Enero";
          break;
        case 2:
          nombreMes = "Febrero";
          break;
        // Agrega más casos según sea necesario
        default:
          nombreMes = "Mes no reconocido";
          break;
      }

      Console.WriteLine($"El mes es: {nombreMes}");
    }

    // Aquí puedes agregar más métodos para practicar con otras estructuras condicionales
  }
}
