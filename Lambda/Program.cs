using System;
using System.Linq;

/*
 Podem ser de alguns jeitos:
(input-parameters) => expression
(input-parameters) => { <sequence-of-statements> }
https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/lambda-expressions#code-try-4
 */

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ParametorsEntrada pe = new();
            Sequence s = new();
            Expression e = new();
            Tuplas t = new();
            ConsultaPadrao cp = new();
            //s.Exemplo();
            //e.Exemplo();
            //pe.Exemplo();
            //t.Exemplo();
            cp.Exemplo();

        }
    }
}
