using System;
using System.Collections.Generic;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            double x = 9.1;
            // object armazena qualquer tipo, podendo até mesmo fazer as contas se for interessante
            object o = (i+x);    // Boxing
            object j = (object)o;  // Unboxing
            Console.WriteLine(o);
            Console.WriteLine(j);

        }
    }
}
