using System;

namespace E21_E22_DeterminarMayorMenorEnArreglo
{   
    //21.- dado un arreglo Arr de tipo entero.Determinar el número más grande almacenado
    //22.- determinar el minimo del anterior
    class Program
    {   
        static void Main(string[] args)
        {
            int[] Arreglo = ObtenerVectorConEnterosAleatorios( 15, 10, 99);
            Console.WriteLine("El arreglo es:");
            foreach (var v in Arreglo)
                Console.WriteLine("[{0}] ", v);
            Console.WriteLine("El valor mayor es: {0}", ObtenerMayor(Arreglo));
            Console.WriteLine("El valor menor es: {0}", ObtenerMenor(Arreglo));
            Console.ReadLine();
        }

        public static int ObtenerMayor(int[] array)
        {
            int mayor = 0;
            if (array.Length > 0)            
                foreach (var v in array)
                    if(v > mayor)                    
                        mayor = v;
            return mayor;
        }

        public static int ObtenerMenor(int[] array)
        {
            int menor = 0;
            if (array.Length > 0)
            {
                menor = array[0];
                foreach (var v in array)
                    if (v < menor)
                        menor = v;
            }
                
            return menor;
        }

        public static int[] ObtenerVectorConEnterosAleatorios(int size, int min, int max)
        {
            Random random = new Random();
            int[] resultado = null;
            if (size > 0 && min < max)
            {
                resultado = new int[size];
                for (int i = 0; i < resultado.Length; i++)
                    resultado[i] = random.Next(min, max);
            }

            return resultado;
        }
    }
}
