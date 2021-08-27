using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Expression
    {
        public void Exemplo()
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            // aqui esta como uma arvore de expressão
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);
            // Output:
            // x => (x * x)

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
            // Output:
            // 4 9 16 25
        }
    }
}
