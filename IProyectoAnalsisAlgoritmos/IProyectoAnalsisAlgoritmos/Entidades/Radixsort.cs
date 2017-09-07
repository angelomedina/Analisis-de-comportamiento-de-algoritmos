using System;
using System.Collections.Generic;
using System.Text;

namespace RadixSort
{
    class Radixsort
    {
        public void impresionInversoRadixSort(int[] copiaArrayInversa)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew(); // averiguar el tiempo
            int[] tamaños = { 10,100, 1000, 5000, 10000,50000}; // solo la estoy probando con 10 mill --> cambiar a 50000
            int a, c; //contadores de asignaciones y comparaciones 

            for (int i = 0; i < tamaños.Length; i++)
            {
                a = c = 0;
                RadixSort(copiaArrayInversa, tamaños[i], ref a, ref c);

                Console.WriteLine(" (tam = {0}", tamaños[i]);
                Console.WriteLine("");
                Console.WriteLine("    - Asignaciones: {0}", a);
                Console.WriteLine("");
                Console.WriteLine("    - Comparaciones: {0}", c);
                Console.WriteLine("");
                Console.WriteLine("    - Cantidad de lineas ejecutadas: {0}", a+c);
                Console.WriteLine("");
                Console.WriteLine("    - Tiempo: " + watch1.Elapsed.TotalSeconds.ToString().Substring(0, 4) + " s");
                Console.WriteLine(" -------------------------------------------");
                Console.WriteLine("");

            }
        }

        public void impresionAleatorioRadixSort(int[] copiaArrayAleatoria)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew(); // averiguar el tiempo
            int[] tamaños = { 10,100, 1000, 5000, 10000, 50000 }; // solo la estoy probando con 10 mill --> cambiar a 50000
            int a, c; //contadores de asignaciones y comparaciones 

            for (int i = 0; i < tamaños.Length; i++)
            {
                a = c = 0;
                RadixSort(copiaArrayAleatoria, tamaños[i], ref a, ref c);

                Console.WriteLine(" (tam = {0}", tamaños[i]);
                Console.WriteLine("");
                Console.WriteLine("    - Asignaciones: {0}", a);
                Console.WriteLine("");
                Console.WriteLine("    - Comparaciones: {0}", c);
                Console.WriteLine("");
                Console.WriteLine("    - Cantidad de lineas ejecutadas: {0}", a + c);
                Console.WriteLine("");
                Console.WriteLine("    - Tiempo : " + watch1.Elapsed.TotalSeconds.ToString().Substring(0, 4) + " s");
                Console.WriteLine(" -------------------------------------------");
                Console.WriteLine("");

            }
        }

        public void impresionAscendenteRadixSort(int[] copiaArrayAscendente)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew(); // averiguar el tiempo
            int[] tamaños = { 10,100, 1000, 5000, 10000, 50000 }; // solo la estoy probando con 10 mill --> cambiar a 50000
            int a, c; //contadores de asignaciones y comparaciones 

            for (int i = 0; i < tamaños.Length; i++)
            {
                a = c = 0;
                RadixSort(copiaArrayAscendente, tamaños[i], ref a, ref c);

                Console.WriteLine(" (tam = {0}", tamaños[i]);
                Console.WriteLine("");
                Console.WriteLine("    - Asignaciones: {0}", a);
                Console.WriteLine("");
                Console.WriteLine("    - Comparaciones: {0}", c);
                Console.WriteLine("");
                Console.WriteLine("    - Cantidad de lineas ejecutadas: {0}", a + c);
                Console.WriteLine("");
                Console.WriteLine("    - Tiempo : " + watch1.Elapsed.TotalSeconds.ToString().Substring(0, 4) + " s");
                Console.WriteLine(" -------------------------------------------");
                Console.WriteLine("");

            }

        }

        public void impresionTotalRadixSort()
        {
            //----------------------------------------------------------------------------------------------------------------------------------------------------
            //instancias 
            Consultas metodosPrincipal = new Consultas();// instancia para el uso general de todos los algoritmos de ordenamiento
            Radixsort metodosRadix = new Radixsort();

            // hago las llamadas para llenar los respaldos de cada array
            metodosPrincipal.Inverso();
            metodosPrincipal.Aleatorio();
            metodosPrincipal.Ascendente();
            bool ok;

            // hago las impresiones de los resultados de Inverso
            Console.WriteLine("****************** Inverso --> RadixSort ****************************************************************");
            metodosRadix.impresionInversoRadixSort(metodosPrincipal.copiaArrayInversa);
            ok = metodosPrincipal.VerificarOrden(metodosPrincipal.copiaArrayInversa, metodosPrincipal.copiaArrayInversa.Length);
            if (ok == false)
            {
                Console.WriteLine("Error en el Inverso");
                ok = true;
            }

            // hago las impresiones de los resultados de Aleatorio
            Console.WriteLine("******************Aleatorio --> RadixSort ************************************************************");
            metodosRadix.impresionAleatorioRadixSort(metodosPrincipal.copiaArrayAleatoria);
            ok = metodosPrincipal.VerificarOrden(metodosPrincipal.copiaArrayAleatoria, metodosPrincipal.copiaArrayAleatoria.Length);
            if (ok == false)
            {
                Console.WriteLine("Error en el Areatorio");
                ok = true;
            }


            // hago las impresiones de los resultados de Aleatorio
            Console.WriteLine("******************Ascendete --> RadixSort *************************************************************");
            metodosRadix.impresionAscendenteRadixSort(metodosPrincipal.copiaArrayAscendente);
            ok = metodosPrincipal.VerificarOrden(metodosPrincipal.copiaArrayAscendente, metodosPrincipal.copiaArrayAscendente.Length);
            if (ok == false)
            {
                Console.WriteLine("Error en el Areatorio");
                ok = true;
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------

        }
        /*
         * Radixsort es un algortimo que ordena numeros enteros de manera individual
         * Ordena con respecto al segundo digito de cada numero menos significativo
         * 1) se colocan los numeros dentro de una lista de colas; ordenados por su números menos significativos
         * 2) se colocan en una nueva lista
         * 3) se miran los numeros en el unidades mas significativos 
        */

        public void RadixSort(int[] v, int n, ref int a, ref int c)
        {
            
            /*
             *  int[] v: es un array a recibir 
             *  int n: es el tamaño de comparaciones
             *  ref a: son las asignaciones
             *  ref c: son las comparaciones
             */ 
                         
            int i, j; a += 1;

            int[] tmp = new int[v.Length]; // hace una copia del tamaño del arry recibido
            for (int shift = n; shift > -1; --shift) 
            {

                j = 0; a += 1;
                for (i = 0; i < v.Length; ++i) // esta es una condicion de for
                {
                    //analiza asignaciones
                    a += 3; // esta linea contempla las 3 asignaciones siguientes

                    // <<: El operador de asignación y desplazamiento a la izquierda.
                    bool move = (v[i] << shift) >= 0; // se va desplazando a la izquierada verificando cada elemento

                    if (shift == 0 ? !move : move)
                    {
                        v[i - j] = v[i]; // hace una asignacion
                        c++; //cada vez una comparacion true o false del if
                    }
                    else
                    {
                        tmp[j++] = v[i];// hace una asignacion
                        c++; //cada vez una comparacion true o false del if
                    }
                }
                Array.Copy(tmp, 0, v, v.Length - j, j);
            }
        }

        


    }
}
