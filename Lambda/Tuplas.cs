using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Tuplas
    {
        public void Exemplo()
        {
            Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
            var numbers = (2, 3, 4);
            var doubledNumbers = doubleThem(numbers);
            Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");
            // Output:
            // The set (2, 3, 4) doubled: (4, 6, 8)

            Func<(int n1, int n2, int n3), (int, int, int)> op = ns => (2 * ns.n1, 2 * ns.n2, 2 * ns.n3);
            var op1 = (2, 3, 4);
            var op2 = doubleThem(numbers);
            Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");
        }
    }
}
