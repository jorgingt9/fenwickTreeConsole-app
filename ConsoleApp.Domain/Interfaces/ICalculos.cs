using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Core.Interfaces
{
    public interface ICalculos
    {
        double calculo1(int id);

        void constructBITree(int[] arr, int n);

        int getSum(int index);

        void updateBIT(int n, int index, int val);
    }
}
