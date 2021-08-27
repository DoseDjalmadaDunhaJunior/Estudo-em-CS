using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class ParametorsEntrada
    {
        public void Exemplo()
        {
            Action a = () => Console.WriteLine();// System.Action
            Func<double, double> b = x => x * x * x; // System.Func`2[System.Double,System.Double]
            Func<int, int, bool> c = (x, y) => x == y; //System.Func`3[System.Int32,System.Int32,System.Boolean] 
            Func<int, string, bool> d = (int x, string s) => s.Length > x; // System.Func`3[System.Int32,System.String,System.Boolean] 
        }
    }
}
