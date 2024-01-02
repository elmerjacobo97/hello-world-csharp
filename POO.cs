using System;

namespace CSharpPractices
{
    // Clase, definir la forma (plantilla) de un objeto
    // Objeto, instancia de una clase
    // Modularización, dividir el código en partes
    // Encapsulamiento, proteger el acceso a los datos
    // Herencia, compartir atributos y métodos
    // Polimorfismo, compartir métodos

    public class POO
    {
        public static void DemostrarClasesObjetosInstancias()
        {
            // Crear una instancia de Coche
            Coche miCoche = new Coche();

            // Asignar valores a los atributos del objeto
            miCoche.Marca = "Toyota";
            miCoche.Modelo = "Corolla";
            miCoche.Anio = 2020;

            // Llamar al método del objeto
            miCoche.MostrarDetalles();

            // Crear una instancia de Persona
            Persona persona = new Persona();
            persona.EstablecerNombre("Juan");
            persona.EstablecerEdad(30);

            // Obtener y mostrar detalles de la persona
            Console.WriteLine($"Nombre: {persona.ObtenerNombre()}, Edad: {persona.ObtenerEdad()}");
            
            // Crear una instancia de Libro con el constructor
            Libro miLibro = new Libro("Cien años de soledad", "Gabriel García Márquez", 1967);
            miLibro.MostrarDetalles();
            
            // Demostrar uso de CuentaBancaria
            CuentaBancaria cuenta = new CuentaBancaria("Juan Pérez", 1000);
            cuenta.Depositar(500);
            cuenta.Retirar(200);
            Console.WriteLine($"Titular: {cuenta.ObtenerTitular()}, Saldo: {cuenta.ObtenerSaldo()}");
            
            // Demostrar uso de Cuenta
            Cuenta miCuenta = new Cuenta("123456789", 1000);
            miCuenta.Depositar(500);
            miCuenta.MostrarBalance();
            
            // Demostrar uso de la clase estática Calculadora
            int resultadoSuma = Calculadora.Sumar(10, 5);
            Console.WriteLine($"Resultado de la suma: {resultadoSuma}");
            Console.WriteLine($"Último resultado: {Calculadora.UltimoResultado}");

            int resultadoResta = Calculadora.Restar(10, 5);
            Console.WriteLine($"Resultado de la resta: {resultadoResta}");
            Console.WriteLine($"Último resultado: {Calculadora.UltimoResultado}");
            
            // Clases anónimas
            var evento = new { Titulo = "Reunión de equipo", Fecha = DateTime.Now };
            Console.WriteLine($"Evento: {evento.Titulo}, Fecha: {evento.Fecha}");
        }
    }

    // Definición de una clase simple Coche
    public class Coche
    {
        // Atributos o propiedades de la clase Coche
        public string Marca;
        public string Modelo;
        public int Anio;

        // Método de la clase
        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}");
        }
    }

    // Definición de una clase Persona con encapsulamiento y métodos privados
    public class Persona
    {
        private string nombre;
        private int edad;

        // Setters
        public void EstablecerNombre(string nombre)
        {
            if (validarNombre(nombre))
            {
                this.nombre = nombre;
            }
            else
            {
                Console.WriteLine("Nombre no válido.");
            }
        }

        // Getters
        public string ObtenerNombre()
        {
            return nombre;
        }

        public void EstablecerEdad(int edad) // public methods, PascalCase
        {
            if (edad > 0)
            {
                this.edad = edad;
            }
            else
            {
                Console.WriteLine("Edad no válida.");
            }
        }

        // Getters
        public int ObtenerEdad()
        {
            return edad;
        }

        // Método privado para validar el nombre
        private bool validarNombre(string nombre) // private methods, camelCase
        {
            // Lógica de validación (por ejemplo, asegurarse de que no esté vacío)
            return !string.IsNullOrEmpty(nombre);
        }
    }
    
    // Definición de una nueva clase Libro con constructor
    public class Libro
    {
        // Atributos de la clase Libro
        public string Titulo;
        public string Autor;
        public int AnioPublicacion;

        // Constructor de la clase Libro
        public Libro(string titulo, string autor, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }

        // Método para mostrar los detalles del libro
        public void MostrarDetalles()
        {
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Año de Publicación: {AnioPublicacion}");
        }
    }
    
    // Definición de una nueva clase CuentaBancaria con getters y setters
    public class CuentaBancaria
    {
        private string titular;
        private double saldo;

        // Constructor
        public CuentaBancaria(string titular, double saldoInicial)
        {
            this.titular = titular;
            saldo = saldoInicial;
        }

        // Setters - Establecer
        public void EstablecerTitular(string titular)
        {
            this.titular = titular;
        }

        // Getters - Obtener
        public string ObtenerTitular()
        {
            return titular;
        }

        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser positiva.");
            }
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Fondos insuficientes o cantidad inválida.");
            }
        }

        public double ObtenerSaldo()
        {
            return saldo;
        }
    }
    
    // Definición de una nueva clase Cuenta usando this
    public class Cuenta
    {
        private string numeroCuenta;
        private double balance;

        // Constructor de la clase Cuenta
        public Cuenta(string numeroCuenta, double balanceInicial)
        {
            this.numeroCuenta = numeroCuenta; // 'this' aclara que estamos hablando de la propiedad de la clase
            balance = balanceInicial;
        }

        // Método para depositar dinero en la cuenta
        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.balance += cantidad; // Uso de 'this' para referirse a la propiedad 'balance' de la clase
            }
            else
            {
                Console.WriteLine("Cantidad a depositar debe ser positiva.");
            }
        }

        // Método para mostrar el balance actual
        public void MostrarBalance()
        {
            Console.WriteLine($"Número de Cuenta: {this.numeroCuenta}, Balance Actual: {this.balance}");
        }
    }
    
    // Definición de una nueva clase Calculadora con métodos y propiedades estáticos
    public static class Calculadora
    {
        // Propiedad estática para almacenar el último resultado
        public static int UltimoResultado { get; private set; }

        // Método estático para sumar dos números
        public static int Sumar(int num1, int num2)
        {
            UltimoResultado = num1 + num2;
            return UltimoResultado;
        }

        // Método estático para restar dos números
        public static int Restar(int num1, int num2)
        {
            UltimoResultado = num1 - num2;
            return UltimoResultado;
        }
    }
}
