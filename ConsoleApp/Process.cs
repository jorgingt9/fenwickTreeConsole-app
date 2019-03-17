using ConsoleApp.Core;
using ConsoleApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Process
    {
        IFenwicktree Calculos;

        public Process(IFenwicktree calculos)
        {
            Calculos = calculos;
        }
        public void Start()
        {
            double result = 0;
            double resultMatriz = 0;
            //codigo general

            resultMatriz = RecorrerMatriz(10,20);

            result = Calculos.calculo1(1);
        }

        private double RecorrerMatriz(int n , int m)
        {
            double val = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    val = val + j;
                }
            }
            return val;
        }
    }
}
