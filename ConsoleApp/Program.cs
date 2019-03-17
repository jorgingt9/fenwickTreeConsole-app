using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Process qp = null;
            qp = DependencyContainer.Instance.Get<Process>();
            qp.Start();
        }
    }
}
