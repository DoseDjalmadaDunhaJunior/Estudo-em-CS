using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Sequence
    {
        public void Exemplo()
        {
            //(input-parameters) => { <sequence-of-statements> }

            // no caso aqui ele recebe inicialmente o World e soma ao Hello anterior
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World"); //no caso aqui é o que o "name" vai virar
                            // Output:
                            // Hello World!

        }
    }
}
