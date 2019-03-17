using ConsoleApp.Core;
using ConsoleApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Process
    {
        IFenwicktree FTree;
        int[] freq = {2, 1, 1, 3, 2, 3, 4, 5, 6, 7, 8, 9};
        private readonly int n = 0;

        public Process(IFenwicktree ftree)
        {
            n = freq.Length;
            FTree = ftree;
        }
        public void Start()
        {
            FTree.constructBITree(freq, n);
            Console.WriteLine("La suma de elementos en arr[0..5]" + " es " + FTree.getSum(5));

            // Actualizar BIT para el cambio anterior en arr[]  
            freq[3] += 6;
            FTree.updateBIT(n, 3, 6);
            // Se obtiene la suma despues de que el valor se actualiza  
            Console.WriteLine("La suma de los elementos en arr[0..5]" + " despues de actualizar es: " + FTree.getSum(5));
            Console.ReadKey();
        }

    }
}
