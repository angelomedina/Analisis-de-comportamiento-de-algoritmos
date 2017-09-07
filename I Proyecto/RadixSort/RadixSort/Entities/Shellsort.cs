using System;
using System.Collections.Generic;
using System.Text;

namespace RadixSort.Entities
{
    class Shellsort
    {
        public void shellSort(int[] arr, int array_size, int n, ref int a, ref int c)
        {
            /*
             * int[] arr: recibe un arreglo con 50000 elementos
             * int array_size: es el tamaño del array
             * int n: es el tamaño en ese momento
             * ref int a: son las asignaciones por referencias
             * ref int c: son las comparaciones por referencias
             */


            int i, j, inc, temp; a += 1; // inicializa variables
            inc = 3; a += 1;             // inicia un incremento con el numero 3
            while (inc > 0)             
            {
                for (i = n; i < array_size; i++) /// hace un recorrido en el array
                {
                    j = i;  a+= 1;
                    temp = arr[i];a += 1;             // temp  almacena un elemento en del array
                    while ((j >= inc) && (arr[j - inc] > temp)) // condicion para el intercambio entre elementos
                    {
                        arr[j] = arr[j - inc]; a+= 1; // cambio de posicion
                        j = j - inc;a+= 1; // cambio de posicion
                    }
                    arr[j] = temp;   a+= 1;// nueva posicion
                }
                if (inc / 2 != 0) // division del decremento del divisor de las partes
                {
                    c+=1;
                    inc = inc / 2;  a+= 1;
                }
                else if (inc == 1)
                {
                    c+= 1;
                    inc = 0; a+= 1;
                }
                else
                {
                    c+= 1;
                    inc = 1; a+= 1;
                }
                c++;
            }
        }

        public void impresionInversoShellSort(int[] copiaArrayInversa)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew(); // averiguar el tiempo
            int[] tamaños = { 10, 100, 1000, 5000, 10000, 50000 }; // solo la estoy probando con 10 mill --> cambiar a 50000
            int a, c; //contadores de asignaciones y comparaciones 

            for (int i = 0; i < tamaños.Length; i++) // este for es para recorrer un array de tamaños 
            {
                a = c = 0;
                shellSort(copiaArrayInversa,copiaArrayInversa.Length, tamaños[i], ref a, ref c);// llama al metodos shellsort

                Console.WriteLine(" (tam = {0}", tamaños[i]);
                Console.WriteLine("");
                Console.WriteLine("    - Asignaciones: {0}", a);
                Console.WriteLine("");
                Console.WriteLine("    - Comparaciones: {0}", c);
                Console.WriteLine("");
                Console.WriteLine("    - Cantidad de lineas ejecutadas: {0}", a + c);
                Console.WriteLine("");
                Console.WriteLine("    - Tiempo: " + watch1.Elapsed.TotalSeconds.ToString().Substring(0, 4) + " s");
                Console.WriteLine(" -------------------------------------------");
                Console.WriteLine("");

            }
        }

        public void impresionAleatorioShellSort(int[] copiaArrayAleatoria)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew(); // averiguar el tiempo
            int[] tamaños = { 10, 100, 1000, 5000, 10000, 50000 }; // solo la estoy probando con 10 mill --> cambiar a 50000
            int a, c; //contadores de asignaciones y comparaciones 

            for (int i = 0; i < tamaños.Length; i++)
            {
                a = c = 0;
                shellSort(copiaArrayAleatoria,copiaArrayAleatoria.Length,tamaños[i], ref a, ref c);

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

        public void impresionAscendenteShellSort(int[] copiaArrayAscendente)
        {
            var watch1 = System.Diagnostics.Stopwatch.StartNew(); // averiguar el tiempo
            int[] tamaños = { 10, 100, 1000, 5000, 10000,50000 }; // solo la estoy probando con 10 mill --> cambiar a 50000
            int a, c; //contadores de asignaciones y comparaciones 

            for (int i = 0; i < tamaños.Length; i++)
            {
                a = c = 0;
                shellSort(copiaArrayAscendente,copiaArrayAscendente.Length,tamaños[i], ref a, ref c);// llamado a shell sort

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

        public void impresionTotalShellSort()
        {
            //----------------------------------------------------------------------------------------------------------------------------------------------------
            //instancias 
            Consultas metodosPrincipal = new Consultas();// instancia para el uso general de todos los algoritmos de ordenamiento
            Shellsort metodosShell = new Shellsort();
            bool ok; // ok es un boolean que se encarga de verificar si el arreglo esta ordenado

            // hago las impresiones de los resultados de Inverso
            Console.WriteLine("****************** Inverso --> ShellSort ****************************************************************");
            metodosShell.impresionInversoShellSort(metodosPrincipal.copiaArrayInversa);
            ok = metodosPrincipal.VerificarOrden(metodosPrincipal.copiaArrayInversa, metodosPrincipal.copiaArrayInversa.Length);
            if (ok == false)
            {
                Console.WriteLine("Error en el Inverso");
                ok = true;
            }

            // hago las impresiones de los resultados de Aleatorio
            Console.WriteLine("******************Aleatorio --> ShellSort ************************************************************");
            metodosShell.impresionAleatorioShellSort(metodosPrincipal.copiaArrayAleatoria);
            ok = metodosPrincipal.VerificarOrden(metodosPrincipal.copiaArrayAleatoria, metodosPrincipal.copiaArrayAleatoria.Length);
            if (ok == false)
            {
                Console.WriteLine("Error en el Areatorio");
                ok = true;
            }


            // hago las impresiones de los resultados de Aleatorio
            Console.WriteLine("******************Ascendete --> ShellSort *************************************************************");
            metodosShell.impresionAscendenteShellSort(metodosPrincipal.copiaArrayAscendente);
            ok = metodosPrincipal.VerificarOrden(metodosPrincipal.copiaArrayAscendente, metodosPrincipal.copiaArrayAscendente.Length);
            if (ok == false)
            {
                Console.WriteLine("Error en el Areatorio");
                ok = true;
            }
            Console.ReadKey();

        }


    }
}
