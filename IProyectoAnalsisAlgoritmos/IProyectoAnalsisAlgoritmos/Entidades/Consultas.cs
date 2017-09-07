using System;
using System.Collections.Generic;
using System.Text;

namespace RadixSort
{
    class Consultas
    {
        // este es el array pricipal donde se hacen las modificaciones y luego se respaldan en las diferntes copias
        //public  int[] vector = new int[50000];
        // estas copias de Arrary mantienen el respaldo de las listas que hay que ordenar
        public  int[] copiaArrayInversa = new int[50000];
        public  int[] copiaArrayAleatoria = new int[50000];
        public  int[] copiaArrayAscendente = new int[50000];


        //LLeno cada una de los arreglos
        public  void Inverso()
        {
            int n = 50000;
            for (int i = 0; i < n; i++)
            {
                copiaArrayInversa[i] = n - i;
            }
        }

        public  void Aleatorio()
        {
            Random rnd = new Random();
            int n = 50000;
            int numero;

            for (int i = 0; i < n; i++)
            {
                numero = rnd.Next(0, 50000);//rand() % tam;
                copiaArrayAleatoria[i] = numero;
            }
        }

        public  void Ascendente()
        {
            int n = 50000;

            for (int i = 0; i < n; i++)
            {
                copiaArrayAscendente[i] = i;

            }
        }

        // verifica que el arreglo luego de ser ordenado por X algoritmo este sea correcto
        public  bool VerificarOrden(int[] v, int n)
        {
            int i;
            bool ordenados = true;

            i = 0;
            while ((i < n - 1) && ordenados) // hace un ciclo con una condicion en true 
            {
                if (v[i] > v[i + 1]) // si  no se cumple este if esque esta ordenado de manera erronea
                    ordenados = false;
                i++;
            }
            return ordenados;
        }



    }
}
