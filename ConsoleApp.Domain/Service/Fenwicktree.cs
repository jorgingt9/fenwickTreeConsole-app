using ConsoleApp.Core.Interfaces;
using System;

namespace ConsoleApp.Service.Core
{
    public class Fenwicktree : IFenwicktree
    {
        readonly static int MAX = 1000;
        private static readonly int[] FTree = new int[MAX];

        public Fenwicktree()
        {

        }

        public double calculo1(int id)
        {
            return 1000;
        }

        public void constructBITree(int[] arr, int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Funcion que asume que la matriz esta preprocesada y se almacenan las sumas parciales de elementos
        /// de la matriz en BITree[]
        /// </summary>
        /// <param name="index"></param>
        /// <returns>la suma de arr [0..index]</returns>
        public int getSum(int index)
        {
            int sum = 0;   
            index = index + 1;

            while (index > 0)
            {
                sum += FTree[index];
                index -= index & (-index);
            }
            return sum;
        }

        /// <summary>
        /// Funcion que actualiza un nodo en el árbol de índice binario (FTree) en el indice proporcionado, 
        /// el valor proporcionado como parametros.
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void updateBIT(int n, int index, int val)
        {
            index = index + 1;

            // Recorre todos los antecesores y adiciona el nuevo valor (val) 
            while (index <= n)
            {
                FTree[index] += val;
                // Actualiza el indice al de su padre en la vista de actualizacion  
                index += index & (-index);
            }
        }
    }
}
