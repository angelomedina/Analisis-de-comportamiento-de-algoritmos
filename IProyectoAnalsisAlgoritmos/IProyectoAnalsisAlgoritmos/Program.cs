using RadixSort;
using RadixSort.Entities;
using System;

namespace IProyectoAnalsisAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Radixsort radix = new Radixsort();
            radix.impresionTotalRadixSort();

            Shellsort shell = new Shellsort();
            shell.impresionTotalShellSort();

            Console.WriteLine("Finalizo");
            Console.ReadKey();

        }
    }
}
