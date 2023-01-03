/*
 * Enunciado: Dado un array de números enteros positivos, donde cada uno
 * representa unidades de bloques apilados, debemos calcular cuantas unidades
 * de agua quedarán atrapadas entre ellos.
 *
 * - Ejemplo: Dado el array [4, 0, 3, 6, 1, 3].
 *
 *          ⏹
 *          ⏹
 *   ⏹💧 💧⏹
 *   ⏹💧⏹⏹💧⏹
 *   ⏹💧⏹⏹💧⏹
 *   ⏹💧⏹⏹⏹⏹
 *
 *   Representando bloque con ⏹︎ y agua con 💧, quedarán atrapadas 7 unidades
 *   de agua. Suponemos que existe un suelo impermeable en la parte inferior
 *   que retiene el agua.
 */

using System;

namespace ContenedorAgua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contenedor contenedor = new Contenedor();
            contenedor.recorrerContenedor();
        }
    }

    public class Contenedor
    {
        int[] contenedor = new int[] {6, 0, 3, 2, 4};
        int mayor = 0;
        int total = 0;
        int pilarA = 0;
        int pilarB = 0;
        int indicePilarA = 0;
        int indicePilarB = 0;

        public void re()
        {
     
        }
        public void recorrerContenedor()
        {

            
            for (int i = 0; i < contenedor.Length-1; i++)
            {
                pilarA = contenedor[i];

                for (int j = 1; j > pilarA; pilarA--)
                {
                    if (pilarA >= contenedor[i + 1])
                    {
                        pilarB = contenedor[i + 1];
                        indicePilarB = i + 1;
                    }
           
                }

               
            }

        }



    }


}
