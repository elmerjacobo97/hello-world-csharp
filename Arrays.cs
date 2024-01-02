using System;

namespace CSharpPractices
{
    public class Arrays
    {
        public static void DemostrarUsoDeArrays()
        {
            // Crear un array de enteros
            int[] numeros = new int[5];
            
            // Inicializar un array de enteros
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;

            // Crear e inicializar un array de strings en una sola línea
            string[] frutas = new string[] { "manzana", "banana", "cereza", "durazno" };
            int[] numeros2 = { 1, 2, 3, 4, 5 };

            // Array multidimensional
            int[,] matriz = new int[2, 3]
            {
                {1, 2, 3}, // Fila 1
                {4, 5, 6}  // Fila 2
            };

            // Array de arrays (array jagged)
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[3] {1, 2, 3};
            jaggedArray[1] = new int[2] {4, 5};

            // Impresión de los arrays
            Console.WriteLine("Array de enteros:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\nArray de strings:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine("\nMatriz multidimensional:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nArray jagged:");
            foreach (int[] arrayInterno in jaggedArray)
            {
                foreach (int valor in arrayInterno)
                {
                    Console.Write(valor + " ");
                }
                Console.WriteLine();
            }
        }
    }
}