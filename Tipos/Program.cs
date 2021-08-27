using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point a = new(10,11);
            var p1 = new Point(0, 0);
            var p2 = new Point(10, 20);
            Console.WriteLine(a.X);
            Console.WriteLine(a.Y);
            Console.WriteLine(p1.X);
            Console.WriteLine(p1.Y);
            Console.WriteLine(p2.X);
            Console.WriteLine(p2.Y);
            */

            var pair = new Pair<int, string>(1, "two");
            int i = pair.First;     // TFirst int
            string s = pair.Second; // TSecond string
            Console.WriteLine(i + "\n" + s);

            Point b = new Point3D(10, 20, 30);
            Console.WriteLine(b.X + "\n" + b.Y + "\n");
        }
    }
}
