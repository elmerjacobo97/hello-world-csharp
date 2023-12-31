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
    
    // Método para practicar condicionales con más lógica
    public static void VerificarMayorDeEdadYDNI()
    {
      int edad = 15; 
      bool tieneDNI = true; 

      // Comprobar si la persona es mayor de edad y tiene DNI
      if (edad >= 18 && tieneDNI)
      {
        Console.WriteLine("La persona es mayor de edad y tiene DNI, por lo tanto, puede sufragar.");
      }
      else if (edad >= 18 && !tieneDNI)
      {
        Console.WriteLine("La persona es mayor de edad pero no tiene DNI, por lo tanto, no puede sufragar.");
      }
      else
      {
        Console.WriteLine("La persona es menor de edad y no puede sufragar.");
      }
    }
    
    // Método para practicar condicionales anidadas
    public static void VerificarPermisoDeConducir()
    {
      int edad = 25;
      bool tienePermiso = true;
      bool permisoVigente = false;

      if (edad >= 18)
      {
        Console.WriteLine("La persona es mayor de edad.");
        // Anidamos una condición adicional dentro de la condición de ser mayor de edad
        if (tienePermiso)
        {
          Console.WriteLine("La persona tiene permiso de conducir.");
          // Otra condición anidada: verificar si el permiso está vigente
          if (permisoVigente)
          {
            Console.WriteLine("El permiso de conducir está vigente. Puede conducir legalmente.");
          }
          else
          {
            Console.WriteLine("El permiso de conducir no está vigente. No puede conducir legalmente.");
          }
        }
        else
        {
          Console.WriteLine("La persona no tiene permiso de conducir.");
        }
      }
      else
      {
        Console.WriteLine("La persona es menor de edad y no puede tener permiso de conducir.");
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
        case 3:
          nombreMes = "Marzo";
          break;
        case 4:
          nombreMes = "Abril";
          break;
        default:
          nombreMes = "Mes no reconocido";
          break;
      }

      Console.WriteLine($"El mes es: {nombreMes}");
    }
  }
}
