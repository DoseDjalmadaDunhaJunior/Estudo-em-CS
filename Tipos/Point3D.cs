using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    /// <summary>
    /// Essa classe herda a classe Point sendo a unica diferença a inclusão da variavel z 
    /// </summary>
    public class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
}
