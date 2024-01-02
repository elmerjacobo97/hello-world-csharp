using System;

namespace CSharpPractices
{
  class App
  {
    static void Main(string[] args)
    {
      // Hello World
      Console.Write("Hello, World!");

      Console.WriteLine("--------------------------");

      // Variables
      Console.WriteLine($"Hello, {Variables.myName}!");
      Console.WriteLine($"myInt = {Variables.myInt}");
      Console.WriteLine(Variables.myFloat);
      Console.WriteLine(Variables.myDouble);
      Console.WriteLine(Variables.myInt + Variables.myFloat + Variables.myDouble);
      Console.WriteLine(Variables.myBool);
      Console.WriteLine(Variables.myConst);
      Console.WriteLine(Variables.myDecimal);

      Console.WriteLine("--------------------------");

      // Concatenación
      Concatenacion.ConcatenacionBasica();
      Concatenacion.ConcatenacionConInterpolacion();
      Concatenacion.ConcatenacionConStringBuilder();

      Console.WriteLine("--------------------------");

      // Operadores
      Operadores.PracticaOperadoresAritmeticos();
      Operadores.PracticaOperadoresAsignacion();
      Operadores.PracticaOperadoresComparacion();
      Operadores.PracticaOperadoresLogicos();
      Operadores.PracticaOperadoresLogicosReales();

      Console.WriteLine("--------------------------");

      // Conversiones
      Conversiones.EnteroADecimal();
      Conversiones.DecimalAEntero();
      Conversiones.OtrasConversiones();

      Console.WriteLine("--------------------------");

      // Condicionales
      Condicionales.PracticaIf();
      Condicionales.PracticaSwitch();
      Condicionales.VerificarMayorDeEdadYDNI();
      Condicionales.VerificarPermisoDeConducir();

      Console.WriteLine("--------------------------");

      // Métodos
      Metodos.MetodoSimple();

      int resultado = Metodos.Sumar(10, 20);
      Console.WriteLine($"Sumar(int, int): {resultado}");

      double resultadoDouble = Metodos.Sumar(10.5, 20.3);
      Console.WriteLine($"Sumar(double, double): {resultadoDouble}");

      string saludo = Metodos.Saludar("Elmer");
      Console.WriteLine(saludo);

      string saludoPersonalizado = Metodos.Saludar("Elmer", "Buenos días");
      Console.WriteLine(saludoPersonalizado);

      Console.WriteLine("--------------------------");
      
      Bucles.PracticaFor();
      Bucles.PracticaWhile();
      Bucles.PracticaDoWhile();
      Bucles.RecorrerColeccion();
      // Bucles.EsperarUsuario();
      
      Console.WriteLine("--------------------------");

      Excepciones.CapturaExcepcionDividePorCero();
      Excepciones.CapturaMultiplesExcepciones();
      // Excepciones.CapturaFormatException();
      // Excepciones.CapturaNullReferenceException();
      // Excepciones.CapturaExcepcionGenerica();
      Excepciones.UsoDeFinally();
      // Excepciones.CapturaExcepcionConFiltro();
      // Excepciones.LanzarExcepcionConThrow();
      
      Console.WriteLine("--------------------------");

      Desbordamiento.DemostracionChecked();
      Desbordamiento.DemostracionUnchecked();
      
      Console.WriteLine("--------------------------");
      
      POO.DemostrarClasesObjetosInstancias();
    }
  }
}

