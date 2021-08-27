using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    /// <summary>
    /// Os parametros recebem os tipos que serão o TFirst e o TSecond
    /// TFirst é a primeira variavel
    /// TSecond é a segunda variavel
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public Pair(TFirst first, TSecond second) =>
            (First, Second) = (first, second);
    }
}
